//Problem 1. Exchange if greater
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

jsConsole.writeLine('Problem 1. Exchange if greater');

var a = 5, // <-- Replace your numbers here
    b = 2,
    c;

if(a>b)
{
   c=a;
    a=b;
    b=c;
}
jsConsole.writeLine(a+' '+b);

    a = 3;
    b = 4;
if(a>b)
{
    c=a;
    a=b;
    b=c;
}
jsConsole.writeLine(a+' '+b);

a = 5.5;
b = 4.5;
if(a>b)
{
    c=a;
    a=b;
    b=c;
}
jsConsole.writeLine(a+' '+b);
jsConsole.writeLine('****************************************');

//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

jsConsole.writeLine('Problem 2. Multiplication Sign');

a=5; // <-- Replace your numbers here
b=2;
c=2;
jsConsole.write('a= '+a+'; b= '+b+'; c= '+c+'; -> ');
var d = a*b*c;
if(d>0){jsConsole.writeLine('+');}
else if(d===0){jsConsole.writeLine('0');}
else if(d<0){jsConsole.writeLine('-');}

a=-2;
b=-2;
c=1;
jsConsole.write('a= '+a+'; b= '+b+'; c= '+c+'; -> ');
d = a*b*c;
if(d>0){jsConsole.writeLine('+');}
else if(d===0){jsConsole.writeLine('0');}
else if(d<0){jsConsole.writeLine('-');}

a=-2;
b=4;
c=3;
jsConsole.write('a= '+a+'; b= '+b+'; c= '+c+'; -> ');
d = a*b*c;
if(d>0){jsConsole.writeLine('+');}
else if(d===0){jsConsole.writeLine('0');}
else if(d<0){jsConsole.writeLine('-');}
jsConsole.writeLine('****************************************');

//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
// Use nested if statements.
jsConsole.writeLine('Problem 3. The biggest of Three');
a=5; // <-- Replace your numbers here
b=2;
c=2;
jsConsole.write('a='+a+'; b='+b+'; c='+c);
if (b > a)
{
    a = b;
}

if (c > a)
{
    a = c;
}

jsConsole.writeLine(' -> The biggest number is: '+ a);

a=0;
b=-2.5;
c=5;
jsConsole.write('a='+a+'; b='+b+'; c='+c);
if (b > a)
{
    a = b;
}

if (c > a)
{
    a = c;
}

jsConsole.writeLine(' -> The biggest number is: '+ a);

a=-0.1;
b=-0.5;
c=-1.1;
jsConsole.write('a='+a+'; b='+b+'; c='+c);
if (b > a)
{
    a = b;
}

if (c > a)
{
    a = c;
}
jsConsole.writeLine(' -> The biggest number is: '+ a);

jsConsole.writeLine('****************************************');

//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements.

jsConsole.writeLine('Problem 4. Sort 3 numbers');
a=5; // <-- Replace your numbers here
b=1;
c=2;
jsConsole.write('a='+a+'; b='+b+'; c='+c);
if (a >= b && a > c)
{
    if (b >= c)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ a +', '+ b+', '+ c);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ a +', '+ c+', '+ b);
    }
}

if (b > a && b >= c)
{
    if (a >= c)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ b +', '+ a+', '+ c);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ b +', '+ c+', '+ a);

    }
}
if (c >= a && c > b)
{
    if (a >= b)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ a+', '+ b);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ b+', '+ a);
    }
}
if (a == b && a == c)
{
    jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ b+', '+ a);
}
//------------------------------------------------------------------
a=-1.1; // <-- Replace your numbers here
b=-0.5;
c=-0.1;
jsConsole.write('a='+a+'; b='+b+'; c='+c);
if (a >= b && a > c)
{
    if (b >= c)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ a +', '+ b+', '+ c);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ a +', '+ c+', '+ b);
    }
}

if (b > a && b >= c)
{
    if (a >= c)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ b +', '+ a+', '+ c);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ b +', '+ c+', '+ a);

    }
}
if (c >= a && c > b)
{
    if (a >= b)
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ a+', '+ b);
    }
    else
    {
        jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ b+', '+ a);
    }
}
if (a == b && a == c)
{
    jsConsole.writeLine(' -> Sorted numbers: '+ c +', '+ b+', '+ a);
}

jsConsole.writeLine('****************************************');

//Problem 5. Digit as word
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

jsConsole.writeLine('Problem 5. Digit as word');
var i,
    len,
    numbers=[2,1,0,5,-0.1,'hi',9,10];
for(i=0,len=numbers.length;i<len;i+=1) {
    jsConsole.write('number= ' + numbers[i] + ' -> ');

    switch (numbers[i]) {
        case 0:
            jsConsole.writeLine("zero");
            break;
        case 1:
            jsConsole.writeLine("one");
            break;
        case 2:
            jsConsole.writeLine("two");
            break;
        case 3:
            jsConsole.writeLine("three");
            break;
        case 4:
            jsConsole.writeLine("four");
            break;
        case 5:
            jsConsole.writeLine("five");
            break;
        case 6:
            jsConsole.writeLine("six");
            break;
        case 7:
            jsConsole.writeLine("seven");
            break;
        case 8:
            jsConsole.writeLine("eight");
            break;
        case 9:
            jsConsole.writeLine("nine");
            break;
        default:
            jsConsole.writeLine("not a digit");
            break;
    }
}

jsConsole.writeLine('****************************************');

//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
 //Note: Quadratic equations may have 0, 1 or 2 real roots.

jsConsole.writeLine('Problem 6. Quadratic equation');

a=2;// <-- Replace your numbers here
b=5;
c=-3;
jsConsole.write('a = '+a+'; b = '+b+'; c = '+c+' -> ');
var x1, x2;
var  d = (b*b) - (4*a*c);
if (d>0)
{
    x1 = (-b - Math.sqrt(d)) / (2 * a);
    x2 = (-b + Math.sqrt(d)) / (2 * a);

    jsConsole.writeLine('x1 = '+x1+'; x2 = '+ x2);
}
else if(d==0)
{
    x1=-b/2*a;
    jsConsole.writeLine('x1=x2= '+ x1);
}
else
{
    jsConsole.writeLine('No real roots.');

}
//--------------------------------------------------
a=-1;
b=3;
c=0;
jsConsole.write('a = '+a+'; b = '+b+'; c = '+c+' -> ');
var x1, x2;
var  d = (b*b) - (4*a*c);
if (d>0)
{
    x1 = (-b - Math.sqrt(d)) / (2 * a);
    x2 = (-b + Math.sqrt(d)) / (2 * a);

    jsConsole.writeLine('x1 = '+x1+'; x2 = '+ x2);
}
else if(d==0)
{
    x1=-b/2*a;
    jsConsole.writeLine('x1=x2= '+ x1);
}
else
{
    jsConsole.writeLine('No real roots.');

}

jsConsole.writeLine('****************************************');

//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

jsConsole.writeLine('Problem 7. The biggest of five numbers');

a=5; // <-- Replace your numbers here
b=2;
c=2;
d=4;
var e=1;
jsConsole.write('a = '+a+'; b = '+b+'; c = '+c+'; d = '+d+'; e = '+e+' -> ');

if (b > a)
{
    a = b;
}

if (c > a)
{
    a = c;
}

if (d > a)
{
    a = d;
}

if (e > a)
{
    a = e;
}
jsConsole.writeLine('The biggest number is: '+ a);
//--------------------------------------------------------
a=-2;
b=-22;
c=1;
d=0;
e=0;
jsConsole.write('a = '+a+'; b = '+b+'; c = '+c+'; d = '+d+'; e = '+e+' -> ');

if (b > a)
{
    a = b;
}

if (c > a)
{
    a = c;
}

if (d > a)
{
    a = d;
}

if (e > a)
{
    a = e;
}
jsConsole.writeLine('The biggest number is: '+ a);
jsConsole.writeLine('****************************************');

//Problem 8. Number as words
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

jsConsole.writeLine('Problem 8. Number as words');

var first='',
     result='',
    hundred,
    output='';
    number=501; //<-- Replace your number here

function digitToWord (digit){
    switch (digit) {
        case 0:
            return'zero';
          break;
        case 1:
            return'one';
            break;
        case 2:
            return'two';
            break;
        case 3:
            return'three';
            break;
        case 4:
            return'four';
            break;
        case 5:
            return'five';
            break;
        case 6:
            return'six';
            break;
        case 7:
            return'seven';
            break;
        case 8:
            return'eight';
            break;
        case 9:
            return'nine';
            break;
        default:
            return'not a digit';
            break;
    }
}

function numbersBeforeHundred(number,first){
    if(!(number%10)){
        return first;
    }
    else{
        return(first+' '+digitToWord(number%10));
    }
}

function beforeHundred(number) {
    if ((number < 0) || (number > 999)) {
        {
            output+='Invalid number!';
        }
    }
    else if (number < 10) {
        output+=digitToWord(number);
    }
    else if ((number >= 10) && (number <= 15)) {
        switch (number) {
            case 11:
                output+='eleven';
                break;
            case 12:
                output+='twelve';
                break;
            case 13:
                output+='thirteen';
                break;
            case 14:
                output+='fourteen';
                break;
            case 15:
                output+='fifteen';
                break;
            default:
                output+='not a digit';
                break;
        }
    }
    else if ((number >= 16) && (number <= 19)) {
        if (number == 18) {
            output+='eighteen';
        }
        else {
            output+=digitToWord(number % 10) + 'teen';
        }
    }
    else if (number >= 20 && number < 30) {
        output+=numbersBeforeHundred(number, 'twenty');
    }
    else if (number >= 30 && number < 40) {
        output+=numbersBeforeHundred(number, 'thirty');
    }
    else if (number >= 40 && number < 50) {
        output+=numbersBeforeHundred(number, 'forty');
    }
    else if (number >= 50 && number < 60) {
        output+=numbersBeforeHundred(number, 'fifty');
    }
    else if (number >= 60 && number < 70) {
        output+=numbersBeforeHundred(number, 'sixty');
    }
    else if (number >= 70 && number < 80) {
        output+=numbersBeforeHundred(number, 'seventy');
    }
    else if (number >= 80 && number < 90) {
        output+=numbersBeforeHundred(number, 'eighty');
    }
    else if (number >= 90 && number < 100) {
        output+=numbersBeforeHundred(number, 'ninety');
    }
    return output;
}

function afterHundred(number){
    hundred='hundred';
    if(!(number%100)){
        result=digitToWord((number/100)|0);
        return(result+' '+hundred);
    }
    else{
        result=(digitToWord((number/100)|0));
        return(result+' '+hundred+' and '+beforeHundred(number%100));
    }
}

if(number<100){
    jsConsole.writeLine(beforeHundred(number));
}
else{
    jsConsole.writeLine(afterHundred(number));
}

