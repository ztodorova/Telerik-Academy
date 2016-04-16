//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//   Write a test function to check if the function is working correctly.
console.log('Problem 5. Appearance count');

function appearanceCount(number,arr) {
    var len,
        i,
        counter = 0;

    for (i = 0; len = arr.length, i < len; i += 1) {
        if (number === arr[i]) {
            counter++;
        }
    }
    return counter;
}

function check(number,array,times){
if (appearanceCount(number,array)===times){
        return true;
    }else{
    return false;
}
}

var array=[1,2,3,4,5,3,5,6,7,3,8,3,3],
    number= 3,
    times=5;
console.log('Array: '+array);
console.log(number+' appears in the array: '+appearanceCount(number,array)+' times');
console.log('Function is working correctly: '+check(3,array,5));



console.log('------------------------');
