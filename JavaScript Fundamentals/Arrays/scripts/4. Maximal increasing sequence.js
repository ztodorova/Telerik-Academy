//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.
//    Example:
//input	                 result
//3, 2, 3, 4, 2, 2, 4	2, 3, 4
console.log('Problem 4. Maximal increasing sequence');
var i,
    j,
    len,
    index,
    maxSeq,
    counter=0,
    maxCounter=0,
    sequence=[3, 2, 3, 4, 2, 2, 4];
console.log('sequence: '+sequence);
for(i=0;len=sequence.length-1, i<len; i+=1){
    if(sequence[i]+1===sequence[i+1]){
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
