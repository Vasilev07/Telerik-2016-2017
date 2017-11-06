function solve(n) {
    let height = Number(n[3]);
    let firstBrick = Number(n[0]);
    let secondBrick = Number(n[1]);
    let thirdBrick = Number(n[2]);
   // console.log(firstBrick);
   // console.log(secondBrick + " " + thirdBrick);
    //let brick = ;
    [n] = [n].map(Number);
    let line = 0;
    for(let i = 0; i < n;i++){
        line += firstBrick;
        console.log(line);
    }
}
solve([1,4,2,3]);