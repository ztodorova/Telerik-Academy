//Problem 1. Numbers
//Write a script that prints all the numbers from 1 to N.
jsConsole.writeLine('Problem 1. Numbers');
var n=18;

for(var i=1;i<=n;i+=1 ) {
    jsConsole.writeLine(i);
}

jsConsole.writeLine('***************************');

//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
jsConsole.writeLine('Problem 2. Numbers not divisible');
n=50;
for(i=0;i<=n;i+=1){
    if(!(((i%3)==0)&&((i%7)==0))){
       jsConsole.writeLine(i);
    }
}
jsConsole.writeLine('***************************');
//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.
jsConsole.writeLine('Problem 3. Min/Max of sequence');
var len,
    min=Number.MAX_VALUE,
    max=Number.MIN_VALUE;
    array=[0,1,3,6,4,8,10]; // <-- Replace your sequence here
for(i=0; len=array.length, i<len;i+=1){
    if(array[i]<min){min=array[i];}
    if(array[i]>max){max=array[i];}
};
jsConsole.write(array);
jsConsole.writeLine(' -> min = '+min+'; max= '+max);
jsConsole.writeLine('***************************');

//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
jsConsole.writeLine('Problem 4. Lexicographically smallest');

function smallestLargestProp(target){
    var smallest='zzzzzzzzzzzzz',
        largest='';

    for(prop in target){
        if (prop<smallest){
            smallest=prop;
        }
        if(prop>largest){
            largest=prop;
        }
    }
    return('object '+target+': smallest property -> '+smallest+'; largest property -> '+largest);
}

jsConsole.writeLine(smallestLargestProp(document));
jsConsole.writeLine(smallestLargestProp(window));
jsConsole.writeLine(smallestLargestProp(navigator));
