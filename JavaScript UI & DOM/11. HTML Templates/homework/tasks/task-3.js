function solve(){
  return function(){
    $.fn.listview = function(data){
      var $this = $(this);
      var template = $('#' + $this.attr('data-template')).html();
      var compiledTemplate = handlebars.compile(template);
      var len;

      for (var i = 0;len=data.length, i<len; i+=1) {
        $this.append(compiledTemplate(data[i]));
      }
    };
  };
}

module.exports = solve;