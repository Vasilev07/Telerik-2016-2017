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
        lagerThan(previous, current, next);
    }
    console.log(counter);

    function lagerThan(previous, current, next) {
        if(previous < current && current > next){
             return counter++;
        }
    }
}
solve(['6', '-26 -25 -28 31 2 27']);