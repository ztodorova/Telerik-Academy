/**
 Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 Example:

 URL	                                                 result
 http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http,
                                                        server: telerikacademy.com
                                                        resource: /Courses/Courses/Details/239
 */
console.log('Problem 7. Parse URL');
var address='http://telerikacademy.com/Courses/Courses/Details/239';
console.log('Address: '+address);
var indexSlashes = address.indexOf('//');
var protocol = address.substring(0, indexSlashes-1);
console.log('[protocol] = '+ protocol);
var indexSlash = address.indexOf('/', indexSlashes+2);
var server = address.substring(indexSlashes+2, indexSlash );
console.log('[server] = '+ server);
var indexSlashLast = address.indexOf('/', indexSlash);
var resource = address.substring(indexSlashLast);
console.log('[resource] = '+ resource);

console.log('#########################################');
