/**
 Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 Example:

 <html>
 <head>
 <title>Sample site</title>
 </head>
 <body>
 <div>text
 <div>more text</div>
 and more...
 </div>
 in body
 </body>
 </html>
 Result: Sample sitetextmore textand more...in body

 */
console.log('Problem 6. Extract text from HTML');

var text = "<html> <head> <title>Sample site</title> </head> <body> <div>text <div>more text</div>and more... </div>in body </body> </html>"

var regex = new RegExp('>([^<]+)<', 'gim');
var match=text.match(regex);
console.log(match);
var res='';
var out=match.forEach(function(item){
 var len=item.length;
 var result=item.substring(1,len-1);
res+=result.trim();});

console.log(res);

console.log('#########################################');