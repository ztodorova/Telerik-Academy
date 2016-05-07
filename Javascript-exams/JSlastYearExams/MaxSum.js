/**
 * Created by Zlatka on 6/10/2015.
 */

function Solve(args) {

    var params=args.slice(1).map(Number);
    var maxSum=params[0] ;
    for(var i=0;i<params.length-1;i+=1){
        var sum=0;
        for(j=i;j<params.length;j+=1){
            sum+=params[j];
            if(sum>maxSum){
                maxSum=sum;
            }
        }
    }
    return maxSum;
}


var input = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];

console.log(Solve(input));
console.log('********************');