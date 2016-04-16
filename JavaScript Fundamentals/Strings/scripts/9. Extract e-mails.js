/**
 Problem 9. Extract e-mails

 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @� should be recognized as emails.
 Return the emails as array of strings.
 */
console.log('Problem 9. Extract e-mails');
var text='gosho@gmail.com bla bla bla pesho_peshev@yahoo.com bla bla gosho_geshev@outlook.com'
function extractEmails(text) {
var result=text.match(/[A-Z0-9._-]+@[A-Z0-9.-]+\.[A-Z]{2,4}/gi);
 return result;
}
console.log('Text: '+text);
console.log('E-mail: '+extractEmails(text));
console.log('#########################################');

