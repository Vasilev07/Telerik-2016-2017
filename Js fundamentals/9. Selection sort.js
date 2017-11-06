function solve(args){
    args.splice(0,1);
    args.sort(function(a, b){return a-b});
    console.log(args.join('\n'));
}
solve(['6', '3', '4', '1', '5', '2', '6']);
solve(['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20']);