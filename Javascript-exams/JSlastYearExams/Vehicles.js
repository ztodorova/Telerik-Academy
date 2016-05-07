/**
 * Created by Zlatka on 6/10/2015.
 */
function solve(params) {
    var s = +params[0];
    var count = 0;
    var cars=4;
    var wheels=10;
    var trikes=3;

    for(var i=0;i<s;i++){
        for(var j=0;j<s;j++){
            for(var k=0;k<s;k++){
                if((cars*i+wheels*j+trikes*k)==s){count++;}
            }
        }
    }
return count;

}

var input=['10'];

console.log(solve(input));

console.log('********************');