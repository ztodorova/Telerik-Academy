//Problem 7. Binary search
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
console.log('Problem 7. Binary search');
var middle,
    left,
    right,
    currentElement,
    element=25;
    array=[1,2,3,4,6,8,9,10,14,25,30];

left=0;
right=array.length-1;

while(left<=right){
    middle=(right+left)/2|0;
    currentElement=array[middle];
    if(currentElement<element){
        left=middle+1;
    }else if(currentElement>element){
        right=middle-1;
    }else{
        break;
    }
}
console.log('array: '+array);
console.log(element+' is on index: '+middle);
