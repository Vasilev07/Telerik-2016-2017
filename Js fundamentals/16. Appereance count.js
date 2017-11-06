function solve(args) {
    let lenght = +args[0];
    let array = args[1].split(' ').map(Number);
    let numberToCount = +args[2];

    let counter = 0;
    console.log(array);
    for (let i = 0; i < lenght; i++) {
        let currentNumber = array[i];
       compare(currentNumber, numberToCount)
    }

    console.log(counter);

    function compare(number, currentNumber) {
        if(number == currentNumber){
              return counter+=1;
        }
    }
}
solve(['8',
    '28 6 21 6 -7856 73 73 -56',
    '73'])