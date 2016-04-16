/**
 Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
console.log('Problem 5. nbsp');
function replaceWhiteSpaces(text,replaceString,withString){
    var reg = new RegExp(replaceString,'gi');
    return text.replace(reg,withString);
}

var text = 'Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var replaced = replaceWhiteSpaces(text,' ','&nbsp');
console.log('Text: '+text);
console.log('Text after replacement: '+replaced);

console.log('#########################################');