//Problem 4. Number of elements
//Write a function to count the number of div elements on the web page
console.log('Problem 4. Number of elements');

function NumberOfDivs(){
    var counter = document.getElementsByTagName('div').length;
    return counter;
}

console.log('Number of divs: '+NumberOfDivs());

console.log('------------------------');