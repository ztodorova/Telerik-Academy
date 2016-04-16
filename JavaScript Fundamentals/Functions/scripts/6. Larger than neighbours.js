//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
console.log('Problem 6. Larger than neighbours');

function LargerThanNeighbours(pos,arr){
    var i,
        len=arr.length;

   if((pos===0) && (arr.len<1)){
       return 'No neighbours';
   }else if((pos===0) && (len>1)){
       if(arr[pos]>arr[pos+1]){
           return true;
       }else{
           return false;
       }
   }else if(pos===len-1){
       if(arr[pos]>arr[pos-1]){
           return true;
       }else{
           return false;
       }
   }else{
       if((arr[pos]>arr[pos-1]) && (arr[pos]>arr[pos+1])){
           return true;
       }else{
           return false;
       }
   }
}

var pos=2;
    array=[1,2,3,4];
    anotherArray=[1,2,6,4];
console.log('Element at position '+pos+' is bigger than its neighbours:')
console.log(array);
console.log(LargerThanNeighbours(pos,array));
console.log(anotherArray);
console.log(LargerThanNeighbours(pos,anotherArray));

console.log('------------------------');