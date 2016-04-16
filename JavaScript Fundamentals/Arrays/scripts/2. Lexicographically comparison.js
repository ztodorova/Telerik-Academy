//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).
console.log('Problem 2. Lexicographically comparison');
var i,
    len,
    firstArray=['a','b','c','d','e','f','g','h'],
    secondArray=['i','j','k','a','e','n','o','p'];
console.log('firstArray = '+firstArray);
console.log('secondArray = '+ secondArray);

for(i=0;len=firstArray.length, i<len; i+=1){
    if(firstArray[i]<secondArray[i]){
    console.log(firstArray[i]+' < '+secondArray[i])
    }
    else if(firstArray[i]>secondArray[i]){
        console.log(firstArray[i]+' > '+secondArray[i]);
    }
else{
        console.log(firstArray[i] + ' = ' + secondArray[i]);
    }
}
console.log('-------------------------------------------');