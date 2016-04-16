/**
 Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */
console.log('Problem 5. Youngest person');

 var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname : 'Bay', lastname: 'Ivan', age: 81}];
var youngest= people.reduce(function(person){
 var min = Number.MAX_VALUE;
 if(person.age<min){
  min = person.age;
 }
 return (person.firstname+' '+person.lastname);
})
people.forEach(function(person){
 console.log(person);
})
console.log('Youngest person: '+youngest);
console.log('*****************************************');