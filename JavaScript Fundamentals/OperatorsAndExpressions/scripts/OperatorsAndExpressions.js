//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even.

jsConsole.writeLine('Problem 1. Odd or Even');

var n = [3,2,-2,-1,0];
for(var i=0;i< n.length;i++)
{
    jsConsole.write(n[i]+' is ');
    if(n[i]%2==0)
    {
        jsConsole.writeLine('even');
    }
    else
    {
        jsConsole.writeLine('odd');
    }
}
i=0;
jsConsole.writeLine('***************************************');

//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

jsConsole.writeLine('Problem 2. Divisible by 7 and 5');

var n = [3,0,5,7,35,140];
for(var i=0;i< n.length;i++)
{
    if(n[i]==0)
    {
        jsConsole.writeLine(n[i]+ ' cannot be divided by 7 and 5 at the same time');
    }
   else if((n[i]%5==0) && (n[i]%7==0)){
        jsConsole.writeLine(n[i]+ ' can be divided by 7 and 5 at the same time');
    }
    else{
        jsConsole.writeLine(n[i]+ ' cannot be divided by 7 and 5 at the same time');
    }
}
i=0;
jsConsole.writeLine('***************************************');

//Problem 3. Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.

jsConsole.writeLine('Problem 3. Rectangle area');

var width = 3,
    height = 4,
    area = width*height;

jsConsole.writeLine('width = 3, height = 4 -> '+'Rectangle\'s area is: '+area);

var width1 = 2.5,
    height1 = 3,
    area1 = width1*height1;

jsConsole.writeLine('width = 2.5, height = 3 -> '+'Rectangle\'s area is: '+area1);

var width2 = 5,
    height2 = 5,
    area2 = width2*height2;

jsConsole.writeLine('width = 5, height = 5 -> '+'Rectangle\'s area is: '+area2);

jsConsole.writeLine('***************************************');

//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

jsConsole.writeLine('Problem 4. Third digit');

var number = 5;

var n = number / 100;

var a = Math.floor((n % 10) === 7);

if(((n % 10)|0) === 7){
    jsConsole.writeLine(number+' -> third digit (right-to-left) is 7');
}
else {
    jsConsole.writeLine(number+' -> third digit (right-to-left) is not 7');
}

var number = 701;

var n = number / 100;

var a = Math.floor((n % 10) === 7);

if(((n % 10)|0) === 7){
    jsConsole.writeLine(number+' -> third digit (right-to-left) is 7');
}
else {
    jsConsole.writeLine(number+' -> third digit (right-to-left) is not 7');
}

var number = 1732;

var n = number / 100;

var a = Math.floor((n % 10) === 7);

if(((n % 10)|0) === 7){
    jsConsole.writeLine(number+' -> third digit (right-to-left) is 7');
}
else {
    jsConsole.writeLine(number+' -> third digit (right-to-left) is not 7');
}

jsConsole.writeLine('***************************************');

//Problem 5. Third bit
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

jsConsole.writeLine('Problem 5. Third bit');

var number= 5,
    mask=1<< 3,
    andMask = number & mask,
     bit = andMask >> 3;
jsConsole.writeLine(number+'-> 3rd bit is: '+bit);

var number1= 8,
    andMask1 = number1 & mask,
    bit1 = andMask1 >> 3;
jsConsole.writeLine(number1+'-> 3rd bit is: '+bit1);

var number2= 0,
    andMask2 = number2 & mask,
    bit2 = andMask2 >> 3;
jsConsole.writeLine(number2+'-> 3rd bit is: '+bit2);

var number3= 62241,
    andMask3 = number3 & mask,
    bit3 = andMask3 >> 3;
jsConsole.writeLine(number3+'-> 3rd bit is: '+bit3);

jsConsole.writeLine('***************************************');

//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
jsConsole.writeLine('Problem 6. Point in Circle');

var xc=0,
    yc=0,
    x=0,
    y=1,
    radius=5;
var distance=Math.sqrt(Math.pow(xc-x,2)+Math.pow(yc-y,2));
if(distance<=radius){
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+true);}
else{
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+false);
}

x=-5;
y=0;
distance=Math.sqrt(Math.pow(xc-x,2)+Math.pow(yc-y,2));
if(distance<=radius){
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+true);}
else{
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+false);
}

x=-4;
y=-3.5;
distance=Math.sqrt(Math.pow(xc-x,2)+Math.pow(yc-y,2));
if(distance<=radius){
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+true);}
else{
    jsConsole.writeLine('{'+x+','+y+'}'+' is within the circle -> '+false);
}


jsConsole.writeLine('***************************************');

//Problem 7. Is prime
//Write an expression that checks if given positive integer number n (n ? 100) is prime.

jsConsole.writeLine('Problem 7. Is prime');

    n = 1;
   var buffer;
for(var i=2;i<n;i++)
{
    if (n%i==0) {
        buffer++;
    }
}
if(buffer==0){
    jsConsole.writeLine(n+'is prime');
}
else{
    jsConsole.writeLine(n+' is not prime');
}
buffer=0;
n = 9;
for(i=2;i<n;i++)
{
    if (n%i==0) {
        buffer++;
    }
}
if(buffer==0){
    jsConsole.writeLine(n+' is prime');
}
else{
    jsConsole.writeLine(n+' is not prime');
}
buffer=0;
n = 97;
for( i=2;i<n;i++)
{
    if (n%i==0) {
        buffer++;
    }
}
if(buffer==0){
    jsConsole.writeLine(n+' is prime');
}
else{
    jsConsole.writeLine(n+' is not prime');
}
buffer=0;

jsConsole.writeLine('***************************************');

//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
jsConsole.writeLine('Problem 8. Trapezoid area');

var a=5,
    b=7,
    h=12,
    area;
area=((a+b)/2)*h;
jsConsole.writeLine('a='+a+', '+'b='+b+', h='+h+' -> '+'The area is: '+area);

var a1=8.5,
    b1=4.3,
    h1=2.7,
    area1;
area1=((a1+b1)/2)*h1;
jsConsole.writeLine('a='+a1+', '+'b='+b1+', h='+h1+' -> '+'The area is: '+area1);

var a2=0.222,
    b2=0.333,
    h2=0.555,
    area2;
area2=((a2+b2)/2)*h2;
jsConsole.writeLine('a='+a2+', '+'b='+b2+', h='+h2+' -> '+'The area is: '+area2);

jsConsole.writeLine('***************************************');

//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

jsConsole.writeLine('Problem 9. Point in Circle and outside Rectangle');

var XY = 1.0;
var radius = 3;
var horizontal = [1,3,0,4,2,4,2.5,3.5,-100];
var vertical = [4,2,1,1,0,0,1.5,1.5,-100];
for (var i = 0; i < horizontal.length ; i++) {
    for (var j = 0; j < horizontal.length ; j++) {
        XY=1.0;
        radius=3;
        var isInsideCircle = (Math.pow((horizontal[i] - XY), 2) + Math.pow((vertical[i] - XY), 2)) <= radius * radius;
    }

    var topV = 1.0;
    var leftH = -1.0;
    var bottomV = -1.0;
    var rightH = 5.0;
    var isOutsideRectangle;
    if (!((horizontal[i] >= leftH && horizontal[i] <= rightH) && (vertical[i] <= topV && vertical[i] >= bottomV)))
    {
        isOutsideRectangle = true;
    }
    else
    {
        isOutsideRectangle = false;
    }
    if (isInsideCircle && isOutsideRectangle)
    {
        jsConsole.writeLine('x: '+horizontal[i]+' y: '+vertical[i]+' -> inside K & outside of R: Yes');
    }
    else
    {
        jsConsole.writeLine('x: '+horizontal[i]+' y: '+vertical[i]+' -> inside K & outside of R: NO');
    }
}