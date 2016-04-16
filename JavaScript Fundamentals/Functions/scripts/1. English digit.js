//Problem 1. English digit

//Write a function that returns the last digit of given integer as an English word.
//    Examples:
//input	output
//512	two
//1024	four
//12309	nine
console.log('Problem 1. English digit');
function LastDigit(integer){
    var digit = integer%10;
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

var len,
    i,
    integers=[512,1024,12309];

for(i=0;len=integers.length,i<len;i+=1)
{
    console.log(integers[i]+' -> '+LastDigit(integers[i]));
}
console.log('------------------------');