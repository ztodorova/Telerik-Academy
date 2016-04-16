/**
 Problem 1. Format with placeholders

 Write a function that formats a string. The function should have placeholders, as shown in the example
 Add the function to the String.prototype
 Example:

 input	output
 var options = {name: 'John'};
 'Hello, there! Are you #{name}?'.format(options);	'Hello, there! Are you John'
 var options = {name: 'John', age: 13};
 'My name is #{name} and I am #{age}-years-old').format(options);	'My name is John and I am 13-years-old'
 */
console.log('Problem 1. Format with placeholders');

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var pattern,
            result = this,
            prop;
        for (prop in options) {
            pattern = new RegExp('\#\{' + prop + '\}');
            result = result.replace(pattern, options[prop]);
        }
        return result;
    }

}
var options01 = { name: 'John' };
var options02 = { name: 'John', age: 13 };
var string01 = 'Hello, there! Are you #{name}?';
var string02 = 'My name is #{name} and I am #{age}-years-old';

function regular01() {
    console.log(string01.format(options01));
    console.log(string02.format(options02));
}

regular01();

console.log('***********************************');

/*
 Problem 2. HTML binding

 Write a function that puts the value of an object into the content/attributes of HTML tags.
 Add the function to the String.prototype
 Example 1:

 input

 var str = '<div data-bind-content="name"></div>';
 str.bind(str, {name: 'Steven'});
 output

 <div data-bind-content="name">Steven</div>
 Example 2:

 input

 var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>'
 str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
 output

 <a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</?>
 */
console.log('Problem 2. HTML binding');

if (!String.prototype.bind) {
    String.prototype.bind = function (str, obj) {
        var pattern = /<[A-z0-9"\s\-=\/]+>/g,
            patternName = /data-bind-content="name"/,
            patternLink = /data-bind-href="link"/,
            patternClass = /data-bind-class="name"/,
            result;
        if (patternName.test(this)) {
            result = this.match(pattern).join(obj.name);
        }
        if (patternLink.test(this)) {
            result = result.replace('>', ' href=' + '"' + obj.link + '">');
        }
        if (patternClass.test(this)) {
            result = result.replace('>', ' class=' + '"' + obj.name + '">');
        }
        return result;
    }
}

var str01 = '<div data-bind-content="name"></div>';
var str02 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';

function regular02() {
    console.log(str01.bind(str01, { name: 'Steven' }));
    console.log(str02.bind(str02, { name: 'Elena', link: 'http://telerikacademy.com' }));
}

regular02();