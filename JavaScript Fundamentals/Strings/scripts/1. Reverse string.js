/**
 Problem 1. Reverse string

 Write a JavaScript function that reverses a string and returns it.
 Example:

 input	output
 sample	elpmas
 */
console.log('Problem 1. Reverse string');
function reverse(string){
    var reversed = string.split("").reverse().join("");
return reversed;
}
var string = 'sample';
console.log('string: '+string );
console.log('reversed string: '+reverse(string));
console.log('#########################################');