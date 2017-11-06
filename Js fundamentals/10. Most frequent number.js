function solve(args) {
    args = args.map(Number);
    args.splice(0,1);

    let result = {};
    for (let obj of args) {
        if(result.hasOwnProperty(obj)){result[obj] +=1;}
        else {result[obj] = 1;}
    }

    let key = Object.keys(result).reduce(function (a, b) {
        return result[a] > result[b] ? a : b
    });

    console.log(key + " (" + result[key] + " times" +")");

}
console.log(solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']));