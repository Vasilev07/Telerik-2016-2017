function solve(args) {
    let array = args[0].split(' ').map(Number);
    let first = array[0],
        second = array[1],
        third = args[2];

    return GetMax(first, GetMax(second, third));

    function GetMax(a,b) {
        if(a > b){
            return a;
        }else if(a < b){
            return b;
        }else {
            return a;
        }
    }

}
console.log(solve(["8 3 6"]));;
console.log(solve(["7 19 19"]));;