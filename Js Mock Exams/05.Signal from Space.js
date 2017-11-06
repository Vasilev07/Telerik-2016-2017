function solve(args) {
    let word = args[0];
    let holder = "";
    for (let i = 0; i < word.length; i++) {
        let currentLetter = word[i];
        if(currentLetter == word[i+1]){
           continue;
        }else {
            holder += currentLetter;
        }
        currentLetter = word[i+1];
    }

    console.log(holder);
}
solve(['Hello'])
