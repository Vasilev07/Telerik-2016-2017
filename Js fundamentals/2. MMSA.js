function solve(args) {

    let array = [];
    //reading the input
    for (let i = 0; i < args.length; i++) {
            array[i] = Number(args[i]);
    }
    //check the max number
    let max = array.reduce(function (a,b) {
        return Math.max(a,b);
    });
    let min = array.reduce(function (a,b) {
        return Math.min(a,b);
    });
    let sum = array.reduce(function (a,b) {
        return a + b;
    });
    let average = sum / array.length;
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + average.toFixed(2));

}
solve(['2', '5', '1']);
//solve(['2', '-1', '4']);