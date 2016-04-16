//Problem 7. First larger than neighbours
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.
console.log('Problem 7. First larger than neighbours');

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
            return true
        }else{
            return false;
        }
    }
}

function FirstLargerThanNeighbours(arr){
    var i,
        len;
    for(i=0;len=arr.length,i<len;i+=1){
        if(LargerThanNeighbours(i,arr)===true){
            return i;
        }
    }
    return -1;

}

var array=[1,2,3,4,5];
console.log(array);
console.log('Index of first element larger than its neighbours: '+FirstLargerThanNeighbours(array));