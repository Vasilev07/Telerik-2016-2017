let array = [1,10,12,18,31,45,14124,4124,1241];

function orderBy(x,y) {
    return x -y;
}

console.log(array.sort(orderBy));

console.log(array.sort(function (x, y) {return x - y}));;
console.log(array.sort((x, y) => x - y));
