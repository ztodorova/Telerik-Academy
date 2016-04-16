/**
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */
console.log('Problem 1. Make person');
var groupByName,
    youngestMale,
    males,
    buffer,
    average,
    females,
    underA,
    min = Number.MAX_VALUE,
    sum=0,
    counter=0,
    checkAge=18;

function createPerson(firstname,lastname,age,gender){
    var person={
        firstName: firstname,
        lastName: lastname,
        age: age,
        gender: gender,
        personInfo: function(){
            return(this.firstName+' '+this.lastName+', '+this.age+', '+this.gender);
        }
    }
    return person;
}

var arrayOfpeople = [
    createPerson('Krystyna', 'Negri',17,true),
    createPerson('Randi','Redner',16,true),
    createPerson('Gordon','Gleason',23,false),
    createPerson('Ozie','Bucklin',24,true),
    createPerson('Patty','Cogswell',25,true),
    createPerson('Noel','Deacon',26,false),
    createPerson('Noel','Zellmer',27,false),
    createPerson('Chad','Keeble',28,false),
    createPerson('Travis','Donnell',29,false),
    createPerson('Gordon','Timmer',29,false)
]

arrayOfpeople.forEach(function(person){console.log(person.personInfo())});
/**
 Problem 2. People of age
 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */
console.log('$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$');
console.log('Problem 2. People of age');
function containsPeopleOfAge(people){
    return people.every(function(person){return person.age>=checkAge;});
}
console.log('The array contains only people of age greater than '+checkAge+' -> '+containsPeopleOfAge(arrayOfpeople));
console.log('$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$');
/*
 Problem 3. Underage people
 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */
console.log('Problem 3. Underage people');
function underAge(people){
    return people.filter(function(person){return (person.age<checkAge)});
}
underA=underAge(arrayOfpeople);
console.log('People under age: ')
underA.forEach(function (person){console.log(person.personInfo());});
console.log('$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$');
/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */
console.log('Problem 4. Average age of females');

females=arrayOfpeople.filter(function(person){return person.gender===true;});
buffer=females.forEach(function(person){sum+=person.age; counter+=1;});
average=sum/counter;
console.log('Average age of females: '+average);
console.log('$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$');
/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */
console.log('Problem 5. Youngest person');

males=arrayOfpeople.filter(function(person){return (!person.gender)});
males.forEach(function(person){if(person.age<min){min=person.age;}});

if(!Array.prototype.find){
    Array.prototype.find=function(callback){
        var i,
            len;
        for(i=0;len=this.length, i<len;i+=1){
            if(callback(this[i],i,this)){
                return this[i];
            }
        }
        return undefined;
    };
}

youngestMale=males.find(function(person){return person.age==min;});
console.log('Youngest male: '+youngestMale.firstName+' '+youngestMale.lastName);
console.log('$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$');
/*
 Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)

 */
console.log('Problem 6. Group people');
groupByname = arrayOfpeople.reduce(function(grouped,person){
    if(grouped[person.firstName[0]]){
        grouped[person.firstName[0]].push(person);
    }else{
        grouped[person.firstName[0]]=[person];
    }
    return grouped;},{});
console.log('People grouped by name:');
console.log(groupByname);
