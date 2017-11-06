function solve(args) {

    let counter = 1;
    let maxCount = 1;
    for (let i = 0; i < args.length; i++) {
        let current = Number(args[i]);
        let next = Number(args[1+i]);
        if(current < next){
            counter++;
            if(maxCount < counter){
                maxCount = counter;
            }
        }else {
            counter = 1;
        }
        current = next;
    }
    console.log(maxCount);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);