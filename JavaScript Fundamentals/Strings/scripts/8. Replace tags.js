/**
 Problem 8. Replace tags

 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 Example:

 input
 <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

 output
 <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
console.log('Problem 8. Replace tags');


 var result='<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
 var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

 console.log('Sentence with replaced <a> tags: ' + replaceTags(input));
 result += 'Sentence with replaced <a> tags: ' + replaceTags(input);

 function replaceTags(input) {
    var result;
    result = input.replace(/<a href="([^"]+)">([^<]+)<\/a>/gi, '[URL=$1]$2[/URL]');

    return result;
}

console.log('#########################################');
