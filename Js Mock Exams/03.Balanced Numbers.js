function solve(args) {

    let sum = 0;
    for (let number of args) {
        let a = Math.floor(number / 100);
        let b = Math.floor(number / 10 % 10);
        let c = Math.floor(number % 10);
        if (a + c == b) {
        sum += Number(number)
        }
        else {
            break;
        }
    }
    console.log(sum);
}
solve(['132', '123']);
solve(['275', '693', '110', '742']);