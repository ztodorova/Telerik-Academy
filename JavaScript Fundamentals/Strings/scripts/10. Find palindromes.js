/**
 Problem 10. Find palindromes

 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
console.log('Problem 10. Find palindromes');
var i,
    j,
    p,
    lenj,
    len;
var text = 'ABBA lamal haha exe';
console.log('Text: '+text);
var words = text.split(' ');
console.log('Palindromes: ');
for (i = 0; len=words.length, i < len; i+=1) {
    var counter = 0;
    for (j = 0, p = words[i].length - 1; j < words[i].length; j++, p--) {
        var current = words[i];

        if (current[j] == current[p]) {
            counter++;
        }

    }
    if (counter == words[i].length) {
        console.log(words[i]);
    }
}
console.log('#########################################');