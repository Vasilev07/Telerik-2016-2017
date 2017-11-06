function solve(args) {
    let n = Number(args[0]);
    let holder = "";
    for (let i = 1; i <= n; i++) {
        holder += i + " ";
    }
    console.log(holder);
}
solve(['5']);
solve(['1']);