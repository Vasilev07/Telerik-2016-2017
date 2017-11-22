function factorial(n){
    //bottom of the code
    if(n === 0){
        return 1;
    }
    //factorial invoke itself
    return factorial(n-1) * n;
}

console.log(factorial(5));