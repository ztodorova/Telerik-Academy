/**
 Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */
console.log('Problem 4. Parse tags');
var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.'
console.log(text);

function toUpper(text) {

    var pattern = new RegExp('<upcase>([^<]+)</upcase>', 'gim');
    while (text.indexOf('<upcase>')>0) {
        var withTags = (text.match(pattern));
        var indexUpStart = (withTags.indexOf('<upcase>') + 9);
        var indexUpEnd = withTags[0].indexOf('</upcase>');

        var withoutTags = withTags[0].substring(indexUpStart, indexUpEnd);
        var result = text.replace(pattern, withoutTags.toUpperCase());
        text=result;
    }
    return text;
}

function toLower(text) {

    var pattern = new RegExp('<lowcase>([^<]+)</lowcase>', 'gim');
    while (text.indexOf('<lowcase>')>0) {
        var withTags = (text.match(pattern));
        var indexUpStart = (withTags.indexOf('<lowcase>') + 10);
        var indexUpEnd = withTags[0].indexOf('</lowcase>');

        var withoutTags = withTags[0].substring(indexUpStart, indexUpEnd);
        var result = text.replace(pattern, withoutTags.toLowerCase());
        text = result;
    }
    return text;
}

function toMix(text) {

    function random(text) {

        var result = '';

        for (var i = 0; i < text.length; i++) {

          var  number = Math.round(Math.random());

            switch (number) {
                case 0:
                    result += text[i].toLowerCase();
                    break;
                case 1:
                    result += text[i].toUpperCase();
                    break;
            }
        }
        return result;
    }


    var pattern = new RegExp('<mixcase>([^<]+)</mixcase>', 'im');
    while (text.indexOf('<mixcase>')>0) {
        var withTags = (text.match(pattern));
        var indexUpStart = (withTags.indexOf('<mixcase>') + 10);
        var indexUpEnd = withTags[0].indexOf('</mixcase>');

        var withoutTags = withTags[0].substring(indexUpStart, indexUpEnd);
        var withoutTaxRandom = random(withoutTags);
        var result = text.replace(pattern, withoutTaxRandom);
       // return result;
        text=result;
    }
    return text;
}

function prase(text){
    var up=toUpper(text);
    var low=toLower(up);
    var mix=toMix(low);
    return mix;
}

console.log(prase(text));

console.log('#########################################');