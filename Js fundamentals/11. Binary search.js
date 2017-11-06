function solve(args) {
    args.splice(0,1);
    let number = args.pop();
    for (let i = 0; i < args.length; i++) {
        let currentNumber = args[i];
        if(currentNumber === number){
            console.log(i);
        }
    }
}
solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32']);