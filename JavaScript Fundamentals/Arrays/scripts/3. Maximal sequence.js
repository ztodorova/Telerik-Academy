//Problem 3. Maximal sequence
//Write a script that finds the maximal sequence of equal elements in an array.
 //   Example:
//input	                          result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	  2, 2, 2
console.log('Problem 3. Maximal sequence');
var i,
    j,
    len,
    index,
    maxSeq,
    counter=0,
    maxCounter=0,
    sequence=[2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
console.log('sequence: '+sequence);
for(i=0;len=sequence.length-1, i<len; i+=1){
    if(sequence[i]===sequence[i+1]){
        counter+=1;
        if(counter>maxCounter){
        maxCounter=counter;
        index=i+1;}
    }
    else{
        counter=0;
    }
}
maxCounter+=1;
maxSeq=sequence.slice(index-maxCounter+1,index+1);
console.log(' -> maximal sequence: '+maxSeq);

console.log('-------------------------------------------');