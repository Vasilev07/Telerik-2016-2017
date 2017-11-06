function solve(args) {
    args = args.map(Number);
    let holderArray = 0;

    for (let i = 1; i < args.length; i++) {
        let currenNum = args[i];
        //even
        if(currenNum % 2 == 0){
            holderArray += currenNum;
            i++;
        }else {
            //odd
            if(i == 1){
                holderArray += currenNum;
            }else {
                if(holderArray*currenNum > 1025){
                    holderArray = (holderArray*currenNum) % 1024;
                }else {
                    holderArray*=currenNum;
                }
            }
        }
    }
    console.log(holderArray);
}
solve([
    '10',
    '1',
    '2',
    '3',
    '4',
    '5',
    '6',
    '7',
    '8',
    '9',
    '0'
])
solve(['9','9','9','9','9','9','9', '9','9', '9'])