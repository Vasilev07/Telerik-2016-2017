function solve(args) {
    let lenght = +args[0];
    let array = args[1].split(' ').map(Number);
    let counter = 0;
    for (let i = 1; i < lenght; i++) {
        if(array.length < 3){
            return 0;
        }
        let previous = array[i-1];
        let current = array[i];
        let next = array[i+1];

        if(current > previous && current > next){
            console.log(i);
            break;
        }
    }

}
solve(['7', '-26 -25 -28 31 2 27 2']);