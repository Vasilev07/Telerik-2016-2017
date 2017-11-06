function solve(args) {
    let numberInEnglish = args % 10;

    function englishNumber(number) {
        switch (number){
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 0:
                return "zero";
        }
    }
    console.log(englishNumber(numberInEnglish));
}
solve(4333333332);
