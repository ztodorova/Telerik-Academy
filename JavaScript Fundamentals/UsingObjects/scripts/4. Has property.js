/**
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */
console.log('Problem 4. Has property');
var pesho={
 firstName:'pesho',
 age:15
}
function hasOwnProperty(obj, prop) {
 var proto = obj.__proto__ || obj.constructor.prototype;
 return (prop in obj) &&
     (!(prop in proto) || proto[prop] !== obj[prop]);
}

if ( Object.prototype.hasOwnProperty ) {
 var hasOwnProperty = function(obj, prop) {
  return obj.hasOwnProperty(prop);
 }
}

var hasPropFirstName = hasOwnProperty(pesho,'firstName');
var hasPropCar = hasOwnProperty(pesho,'car');

console.log('Obj:')
console.log(pesho);
console.log('obj pesho has property: '+'firstName-> '+hasPropFirstName);
console.log('obj pesho has property: '+'car-> '+hasPropCar);
console.log('*****************************************');