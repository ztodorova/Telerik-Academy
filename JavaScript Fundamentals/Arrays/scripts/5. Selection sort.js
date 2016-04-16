//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//    Write a script to sort an array.
//    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array
console.log('Problem 5. Selection sort');
var i,
    j,
    tmp,
    tmp2,
    array = [2,4,1,3,6,7,9];
console.log('Not sorted: '+array);
for (i = 0; i < array.length - 1; i++) {
    tmp = i;
    for (j = i + 1; j < array.length; j++) {
        if (array[j] < array[tmp]) {
            tmp = j;
        }
    }
    if (tmp != i) {
        tmp2 = array[tmp];
        array[tmp] = array[i];
        array[i] = tmp2;
    }
}
console.log('Sorted: '+array);

console.log('-------------------------------------------');
