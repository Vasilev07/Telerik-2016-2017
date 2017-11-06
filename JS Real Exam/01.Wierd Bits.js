function solve(n) {

    let value = Math.abs(n[0]);
    let sum = 0;

    while (value){
        sum += value % 10;
        value = Math.floor(value / 10);

    }

    console.log(sum);
}
solve([5]);
solve([-343]);
//solve(102000034000567.00000800000900);
//solve([1.1]);