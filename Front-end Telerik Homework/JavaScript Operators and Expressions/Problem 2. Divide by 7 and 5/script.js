function solve(args){
    var num1 = parseInt(args[0]);
    if ((num1 % 7 === 0) && (num1 % 5 ===0)){
        console.log("true" + " " + num1);
    }
    else{
      console.log("false"+ " " + num1);
    };
}
