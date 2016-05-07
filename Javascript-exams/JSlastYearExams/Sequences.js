/**
 * Created by Zlatka on 6/9/2015.
 */
function Solve(input) {

    var result = 1;
    input = input.map(Number);

    for (var i = 2; i < input.length; i++) {
        if (input[i - 1] > input[i]) {
            result++;
        }
    }
    return result;
}

var input = [
    '7',
    '1',
    '2',
    -3,
    4,
    4,
    0,
    1
];

var input1 = [
    6,
    1,
    3,
    -5,
    8,
    7,
    -6

];

console.log(Solve(input));
console.log(Solve(input1));

console.log('*******************');
