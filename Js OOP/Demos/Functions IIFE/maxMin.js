let numbers = [1,2,3,4,5,6,111,23,48,70];
let max = Math.max.call(this,numbers);
let min = Math.min.apply(null, numbers);

console.log(max);
console.log(min);

function sum(){
    var numbers = [].slice.apply(arguments);

    return numbers.reduce((x,y) => x + y);
}

console.log(sum(1,2,3,4));
