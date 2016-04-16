/**
 Problem 2. Correct brackets

 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
console.log('Problem 2. Correct brackets');
function checkBrackets(string){
    var i,
        len
        buffer=0;
   for(i=0;len=string.length,i<len;i+=1){
       switch(string[i]){
           case '(': buffer+=1;
               break;
           case ')': buffer-=1;
           default:break;
       }
   }
    if(!buffer) {
        return true;
    }else{
        return false;
    }
}

var string = '((a+b)/5-d)';
console.log('Expression: '+string);
console.log('Brackets are put correctly -> '+checkBrackets(string));
console.log('#########################################');