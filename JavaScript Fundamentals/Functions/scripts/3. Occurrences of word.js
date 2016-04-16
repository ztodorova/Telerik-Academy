//Problem 3. Occurrences of word
//Write a function that finds all the occurrences of word in a text.
//    The search can be case sensitive or case insensitive.
 //   Use function overloading.
console.log('Problem 3. Occurrences of word');
function WordOccurrences(word,text,caseSensitive){
switch(arguments.length){
    case 2:
        var counter = 0,
            index = text.indexOf(word);
        word=word.toLowerCase();
        text=text.toLowerCase();
        while(index >= 0)
        {
            counter++;
            index = text.indexOf(word, index+1);
        }

        return counter;

    break;

    case 3:

    var counter = 0,
        index = text.indexOf(word);
    while(index >= 0)
    {
        counter++;
        index = text.indexOf(word, index+1);
    }

    return counter;
    break;

}
}

var caseSensitive,
    word='Smile',
    text='Smile haha smile haha';
var result=WordOccurrences(word,text);
console.log('Case insensitive: '+ result);
result=WordOccurrences(word,text,caseSensitive);
console.log('Case sensitive:'+result);


console.log('------------------------');

