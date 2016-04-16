/**
 Problem 3. Sub-string in text

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */
console.log('Problem 3. Sub-string in text');

function subString(string,subString){
    var pattern= new RegExp(subString,'gim');
    var result = (string.match(pattern) || []).length;
    return result;
}

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var sub = 'in';
var test = subString(text,sub);
console.log(text);
console.log('"'+sub+'" appears '+test+' times');
console.log('#########################################');