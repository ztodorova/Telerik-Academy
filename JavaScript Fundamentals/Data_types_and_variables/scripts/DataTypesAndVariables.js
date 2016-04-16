//Problem 1. JavaScript literals
//Assign all the possible JavaScript literals to different variables.
jsConsole.writeLine('Problem 1. JavaScript literals:\n');

var intvar = 1,
    floatvar = 2.2,
    boolvar = true,
    stringvar = 'three',
    objectvar = {
        name: 'Pesho'
    },
    arrayvar = [1,2,3,4];
    var functionvar = function(){
        jsConsole.writeLine('This is a function');
    }

jsConsole.writeLine('var intvar ='+ intvar);
jsConsole.writeLine('var floatvar ='+ floatvar);
jsConsole.writeLine('var boolvar ='+ boolvar);
jsConsole.writeLine('var stringvar ='+ stringvar);
jsConsole.writeLine('var objectvar ='+ objectvar.name);
jsConsole.writeLine('var arrayvar ='+ arrayvar);
functionvar();



//Problem 2. Quoted text
//Create a string variable with quoted text in it.
// For example: `'How you doin'?', Joey said'.

jsConsole.writeLine('Problem 2. Quoted text:\n');

var quotedText = '\'How you doin\'?\',Joey said';

jsConsole.writeLine(quotedText);

//Problem 3. Typeof variables
//Try typeof on all variables you created.
jsConsole.writeLine('Problem 3. Typeof variables');

jsConsole.writeLine('Typeof intvar: '+typeof(intvar));
jsConsole.writeLine('Typeof floatvar: '+typeof(floatvar));
jsConsole.writeLine('Typeof boolvar: '+typeof(boolvar));
jsConsole.writeLine('Typeof stringvar: '+typeof(stringvar));
jsConsole.writeLine('Typeof objectvar: '+typeof(objectvar));
jsConsole.writeLine('Typeof arrayvar: '+typeof(arrayvar));

jsConsole.writeLine('Typeof quotedText: '+typeof(quotedText));

//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.
jsConsole.writeLine('Problem 4. Typeof null');

var nullvar = null,
undefinedvar = undefined;

jsConsole.writeLine('Typeof nullvar: '+typeof(nullvar));
jsConsole.writeLine('Typeof undefinedvar: '+typeof(undefinedvar));