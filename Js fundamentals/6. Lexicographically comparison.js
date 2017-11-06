function solve(args) {
    let firstWord = args[0];
    let secondWord = args[1];
    let smallerWord = Math.max(firstWord.length, secondWord.length);
    if(firstWord.length == secondWord.length){
        if(firstWord == secondWord){
            return '=';
        }
    }else {
        for (let i = 0; i < smallerWord; i++) {
            if(firstWord[i] > secondWord[i]){
                return '<';
            }else {
                return '>';
            }
        }
    }
}

console.log(solve(['hello', 'halo']));;
console.log(solve(['food', 'food']));;

