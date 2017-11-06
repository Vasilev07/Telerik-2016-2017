function solve(args) {
    args  = +args[0];
    let result = [];
    for (let i = 0; i < args; i += 1) {
           result[i] = i*5;
           console.log(result[i])
    }
}
solve(['5']);