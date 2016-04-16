//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.
//    Example:
//input	                                       result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	      4(5 times)
console.log('Problem 6. Most frequent number');
var i,
    j,
    len,
    mostFreq=0,
    maxCounter=0,
    counter= 0,
    array=[4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

for(i=0;len=array.length, i<len;i+=1){
   for(j=0;j<len;j+=1){
       if(array[i]==array[j]){
           counter+=1;
           if(counter>maxCounter){
               maxCounter=counter;
               mostFreq=array[i];
           }
       }
   }
    counter=0;
}
console.log('sequence: '+array);
console.log('most frequent number: '+mostFreq+' ('+maxCounter+' times)');

console.log('-------------------------------------------');