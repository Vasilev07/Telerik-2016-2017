function solve([args]) {
    [args]= [args].map(Number);
    let sum = 0;
    for (let i = 1; i < args.length; i++) {
        let prevoius = args[i-1];
        let current = args[i];
        let next = args[i+1];
        let peak = false;
        let pocket = false;
       if(current > prevoius && current > next){
        peak = true;

        if(peak){
            sum += current;
        }
       }
    }
    console.log(sum);
}
solve(["53 20 1 30 2 40 3 10 1"])