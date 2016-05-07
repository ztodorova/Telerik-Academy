function solve(params) {
    var s = +params[0], c1 = +params[1], c2 = +params[2], c3 = +params[3];
    var sum = 0,
        maxSum = 0;
    for (var i = 0; i < s/c1+1; i+=1) {
        for (var j = 0; j < s/c2+1; j+=1) {
            for (var k = 0; k < s/c3+1; k+=1) {
                if ((i * c1 + j * c2 + k * c3) <= s) {
                    sum = (i * c1 + j * c2 + k * c3);
                }
                if (sum > maxSum) {
                    maxSum = sum;
                }
            }
        }

    }
    return maxSum;
}
var input=[110,
    13,
    15,
    17
];

console.log(solve(input));
console.log('********************');