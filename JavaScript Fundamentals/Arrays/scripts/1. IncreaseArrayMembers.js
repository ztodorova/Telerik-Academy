//Problem 1. Increase array members
//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

console.log('Problem 1. Increase array members');
var i,
    integers=[];
for(i=0;i<20;i+=1){
    integers[i]=i*5;
    console.log('index'+i+': '+integers[i]);
}
console.log('-------------------------------------------');