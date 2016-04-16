/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */
console.log('Problem 3. Deep copy');

function deepCopy(original){
 return JSON.parse(JSON.stringify(original));
}

var primitive=5;
    pesho={
 name:'pesho',
 age:15
}

var copyOfPrimitive = deepCopy(primitive);
    copyOfPesho=deepCopy(pesho);
console.log('object:');
console.log(pesho);
console.log('copy of object:')
console.log(copyOfPesho);
console.log('primitive type variable: ');
console.log(primitive);
console.log('copy of primitive type variable: ');
console.log(copyOfPrimitive);
console.log('*****************************************');




