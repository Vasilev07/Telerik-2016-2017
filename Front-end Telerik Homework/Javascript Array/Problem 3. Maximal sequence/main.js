/*
function maxSeq(args) {
    args = args.map(parseFloat);
    var min = Math.min(args),
        max = Math.max(args),
        sum = sumElements(args);
        avg = sum / args.length;

    function sumElements(sum) {
        var counter = 0;
        for (var i = 0; i < sum.length; i += 1) {
            counter += sum[i];
        }
        return counter;
    }
    console.log();
} //min , max , sum ,avg;
*/
//replace somethng global - cheat
//matrix
/*
function functionName(args) {
  var n = +args[0];
  for (var i = 0; i < n; i+=5) {
    console.log(i);
  }
} // allocate arr
*/
/*
function allocate(args) {
    var n = 5,
        arr = [];
    for (var i = 0, j = 0; i < n, j < n; i += 5, j += 1) {
      arr[j] = i ;
    }
    console.log(arr.join('\n'));
}
allocate();
*/
/*
function lexicoComp(args) {
    var n = +args[0],
        counter = 1,
        max = 0;
    for (var i = 0; i < args.length - 1; i++) {
        if (args[i] == args[i + 1]) {
            counter += 1;
            if (counter > max) {
              max = counter;
            }
        } else {
            counter = 1;
        }

    }
    console.log(max);
}
lexicoComp(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);
*/
/*
function lexicoComp(args) {
  var n = +args[0],
      counter= 0;
      for (var i = 0; i < args.length-1; i++) {
        if () {

        }
      }
}
lexicoComp(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);
//
*/
/*
function solve(params) {
    let s = params[0].split(' ').map(Number),
        maxRocks = 1,
        currentRocks = 1;

    for (let i = 1; i < s.length; i += 1) {
        if (!checkIfRock(i)) {
            if (!chekIfValley(i)) {
                currentRocks += 1;
                if (currentRocks > maxRocks) {
                    maxRocks = currentRocks;
                }
            }
        } else {
            currentRocks = 1;
        }
    }

    console.log(maxRocks + 1);

    function checkIfRock(index) {
        if (s[index - 1] === undefined) {
            return s[index] > s[index + 1];
        } else if (s[index + 1] === undefined) {
            return s[index] > s[index - 1];
        }else{
        return s[index] > s[index + 1] && s[index] > s[index - 1]
    }

    function checkIfValley(index) {

        return s[index] < s[index + 1] && s[index] < s[index - 1];
    }
}
}
solve(['5 1 7 4 8']);
solve(['5 1 7 6 3 6 4 2 3 8']);
solve(['10 1 2 3 4 5 4 3 2 1 10']);
//hills
*/

function solve(args) {
   "use strict";
    let k = Number(args[0].split(' ')[1]);
    let numbers = args[1].split(' ').map(Number);

    function transform(num, left, right) {
        if (num === 0) {
            return Math.abs(left - right);
        } else if (num % 2 === 0) {
            return Math.max(left, right);
        } else if (num === 1) {
            return left + right;
        } else {
            return Math.min(left, right);
        }
    }
    for (let i = 0; i < k; i += 1) {
        let currentTransformation = [];

        for (let j = 0; j < numbers.length; j += 1) {
            let nextValue;

            if (j === 0) {
                nextValue = transform(numbers[j], numbers[numbers.length - 1], numbers[1]);
            } else if (j === (numbers.length - 1)) {
                nextValue = transform(numbers[j], numbers[j - 1], numbers[0]);
            } else {
                nextValue = transform(numbers[j], numbers[j - 1], numbers[j + 1]);
            }
            currentTransformation.push(nextValue);
        }
        numbers = currentTransformation;
    }

    let sum = 0;
    for (let num of numbers) {
        sum += num;
    }
    console.log(numbers)
    console.log(sum);
}
solve(['5 1', '9 0 2 4 1']);
solve(['10 3', '1 9 1 9 1 9 1 9 1 9']);
/*
//function checkIfHeights(index) {
  //  if (s[index - 1] === undefined) {
      //  return s[index] > s[index + 1];
  //  } else if (s[index + 1] === undefined) {
    //    return s[index] > s[index - 1];
  //} else {
  //      return s[index] > s[index + 1] && s[index] > s[index - 1]
  //  }
//  }
