function solve(){
    var player=(function(){

        function getSortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                }
                else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                }
                else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                }
                else {
                    return 0;
                }
            }
        };
        var playerid = 0;
        var player = {
            init: function(name){
                this.name=name;
                this.id = ++playerid;
                this._playlists=[];
                return this;
            },

            addPlaylist: function(playlistToAdd){
            if(typeof(playlistToAdd.id) === 'undefined' || !playlistToAdd.name){
                throw new Error('Invalid playlist');
            }
                this._playlists.push(playlistToAdd);
                return this;
            },

            getPlaylistById: function(id){
                var result;
                this._playlists.forEach(function(playlist){
                    if(playlist.id == id){
                       result = playlist;
                    }
                });

                if(result){
                    return result;
                }
                else{
                    return null;
                }
            },

            removePlaylist: function(id){
                var indexOfPlaylistToRemove;
                this._playlists.forEach(function(playlist){
                    if(playlist.id == id){
                        indexOfPlaylistToRemove == this._playlists.indexOf(playlist);
                    }
                });

                //if (indexOfPlaylistToRemove == undefined){
                //    throw new Error('Playlist id not found!');
               // }

                this._playlists.splice(indexOfPlaylistToRemove,1);
                return this;

            },


            removePlaylist: function(playlist){
                var indexOfPlaylistToRemove;
                this._playlists.forEach(function(item){
                    if(item.id == playlist.id){
                        indexOfPlaylistToRemove == this._playlists.indexOf(item);
                    }
                });

              //  if (indexOfPlaylistToRemove == undefined){
                //    throw new Error('Playlist id not found!');
              //  }

                this._playlists.splice(indexOfPlaylistToRemove,1);
                return this;

            },

            listPlaylists: function(page, size){

                    //validator.validatePageAndSize(page, size, this._playlists.length);

                    return this._playlists
                        .slice()
                        .sort(getSortingFunction('name', 'id'))
                        .splice(page * size, size);
                },

            contains: function(playable, playlist){
                var containsPlayable=false;
            playlist.forEach(function(item){
                if(item.id == playable.id){
                    containsPlayable = true;
                }
            });
                return containsPlayable;
            },

            search: function(pattern){

            }
        };

        return player;
    }());

    var playlist = (function(){
        var id=0;
        var playlist = {
            init: function(name){
                this.name = name;
                this.id = ++id;
                this._playables=[];
                return this;
            },

            addPlayable: function(playable){
                this._playables.push(playable);
                return this;
            },

            getPlayableById: function(id){
                var result;
                this._playables.forEach(function(playable){
                    if(playable.id == id){
                        result = playable;
                    }
                });

                if(result){
                    return result;
                }
                else{
                    return null;
                }
            },

            removePlayable: function(id){
                var indexOfPlayable;
                this._playables.forEach(function(item){
                    if(item.id == id){
                        indexOfPlayable = this._playables.indexOf(item);
                    }

                    if(indexOfPlayable == undefined){
                        throw new Error('Playable not found!');
                    }

                    this._playables.splice(indexOfPlayable,1);

                    return this;
                });
            },

            removePlayable: function(playable){
                var indexOfPlayable;
                this._playables.forEach(function(item){
                    if(item.id == playable.id){
                        indexOfPlayable = this._playables.indexOf(item);
                    }

                    if(indexOfPlayable == undefined){
                        throw new Error('Playable not found!');
                    }

                    this._playables.splice(indexOfPlayable,1);

                    return this;
                });
            },

            listPlayables: function(page, size){

            }
        }
        return playlist;
    }());

    var playable = (function(){
        var id = 0;
        var playable = {
            init: function(title,author){
                this.title = title;
                this.author = author;
                this.id = ++id;
                return this
            },
            play: function(){
                return this.id+'. '+this.title+' - '+this.author;
            }
        }
        return playable;
    }());

    var audio = (function(parent){
        var audio = Object.create(parent);

        Object.defineProperty(audio,'init',{
            value: function(title,author,length){
                parent.init.call(this,title,author);
                this._length = length;
                return this;
            }
        });

        Object.defineProperty(audio,'length',{
          get: function(){
                return this._length;
          },
              set: function(value){
            if(value<0){
                throw new Error();
            }
                  this._length = value;
              }
        });

        Object.defineProperty(audio,'play',{
          value: function(){
              var baseResult = parent.play.call(this);
              return baseResult+' - '+this.length;
          }
        });

        return audio;
    }(playable));

    var video = (function(parent){
        var video = Object.create(parent);

        Object.defineProperty(video,'init',{
            value: function(title,author,imdbRating){
                parent.init.call(this,title,author);
                this._imdbRating = imdbRating;
                return this;
            }
        });

        Object.defineProperty(video,'imdbRating',{
            get: function(){
                return this._imdbRating;
            },
            set: function(value){
                if(value < 1 || 5 < value){
                    throw new Error('Invalid imdbRating!');
                }
                this._imdbRating = value;
            }
        });

        Object.defineProperty(video,'play',{
            value: function() {
                var baseResult = parent.play.call(this);
                return baseResult+' - '+this._imdbRating;
            }
        });

        return video;
    }(playable));

    var module = {
        getPlayer: function (name){
            // returns a new player instance with the provided name
            return Object.create(player).init(name);
        },
        getPlaylist: function(name){
            //returns a new playlist instance with the provided name
            return Object.create(playlist).init(name);
        },
        getAudio: function(title, author, length){
            //returns a new audio instance with the provided title, author and length
            return Object.create(audio).init(title,author,length);
        },
        getVideo: function(title, author, imdbRating){
            //returns a new video instance with the provided title, author and imdbRating
            return Object.create(video).init(title, author, imdbRating);
        }
    };
    return module;
}