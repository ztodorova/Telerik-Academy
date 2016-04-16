//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.
 //   Example:
//input	    output
//256	    652
//123.45	54.321
console.log('Problem 2. Reverse number');
function ReverseNumber(number){
    var string = number.toString(),
        reversed=string.split("").reverse().join("");

    return reversed;
}

var i,
    len,
    numbers=[256,123.45];

for(i=0;len=numbers.length,i<len;i+=1){
    console.log(numbers[i]+' -> '+ReverseNumber(numbers[i]));
}

console.log('------------------------');

