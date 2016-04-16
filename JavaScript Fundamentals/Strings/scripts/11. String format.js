/**
 Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 Examples:

 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';

 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */

console.log('Problem 11. String format');

var result = '';

var str = stringFormat('Hello {0}!', 'Peter'),
    frmt = '{0}, {1}, {0} text {2}',
    str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');

console.log(str);
console.log(str2);
result += str + '<br />';
result += str2;

function stringFormat() {
 var i,
     regex,
     exp,
     formattedString = arguments[0];

 for (i = 1; i < arguments.length; i++) {
  exp = '{[' + (i - 1) + ']}';
  regex = new RegExp(exp, 'g');
  formattedString = formattedString.replace(regex, arguments[i]);
 }

 return formattedString;
}


console.log('#########################################');
