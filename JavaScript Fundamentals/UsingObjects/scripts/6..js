/**
 Problem 6.

 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with props - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */
console.log('Problem 6.');

function buildPerson(firstname, lastname, age) {
 return {
  firstname: firstname,
  lastname: lastname,
  age: age,
  toString: function toString() {
   return this.firstname + ' ' + this.lastname + ' ' + this.age;
  }
 }
}

function group(peopleArray, prop) {
 var associativeArray = {};
 for (var i in peopleArray) {
  var assoProperty = peopleArray[i][prop];
  associativeArray[assoProperty] = [];
  for (var k in peopleArray) {
   if (assoProperty === peopleArray[k][prop]) {
    associativeArray[assoProperty].push(peopleArray[k]);
   }
  }
 }
 return associativeArray;
}

var doncho = buildPerson('Gosho', 'Peshov', 27);
var evlogi = buildPerson('Gosho', 'Peshov', 22);
var niki = buildPerson('Gosho', 'Goshev', 22);
var doni = buildPerson('Pesho', 'Goshev', 27);
var koki = buildPerson('Pesho', 'Goshev', 22);

var peopleArray = [doncho, evlogi, niki, doni, koki];
var groupedByFname = group(peopleArray, 'firstname');
var groupedByLname = group(peopleArray,'lastname');
var groupedByAge = group(peopleArray, 'age');

function groupArray(peopleArray) {
 for (var i = 0; i < peopleArray.length; i++) {
  console.log(peopleArray[i].toString());
 }
 console.log('Grouped by first name:');
 for (var group in groupedByFname) {

  if (group !== 'undefined') {
   console.log(group);
   console.log(groupedByFname[group].toString());
  };
 }
 console.log('Grouped by last name:');
 for (var group in groupedByLname) {

  if (group !== 'undefined') {
   console.log(group);
   console.log(groupedByLname[group].toString());
  };
 }
 console.log('Grouped by age:');
 for (var group in groupedByAge) {

  if (group !== 'undefined') {
   console.log(group);
   console.log(groupedByAge[group].toString());
  };
 }
}

groupArray(peopleArray);


console.log('*****************************************');