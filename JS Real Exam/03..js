function solve(n) {
    n[0] = n[0].split(' ');
    let distanceHolder = [];
    let numbers = [];
    let sum = 0;
    for (let i = 0; i < n[0].length; i++) {
        numbers[i] = Number(n[0][i]);
    }

    for (let i = 1; i < numbers.length; i++) {
        let current = numbers[i];
        let prevoius = numbers[i-1];
        let distance = Math.abs(Math.max(current, prevoius) - Math.min(current,prevoius));
        if(distance % 2 == 0){
            distanceHolder[i-1] = distance;
            distanceHolder[i] = 0;
            i++;
        }else {
            distanceHolder[i-1] = distance;
        }
    }

    for (let i = 0; i < distanceHolder.length; i++) {
        if(distanceHolder[i] % 2 ==0){
            sum+=distanceHolder[i];
        }
    }



    console.log(sum);
}
solve(["1 6 8 10 3 1 1"]);
solve(["-5 5 1 8 -4 1 2"]);