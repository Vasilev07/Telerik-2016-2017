function solve(args) {
    var arr = +args[0];
    
    var numToString = arr.toString();

    var number = numToString[numToString.length - 3];

    if(number === "7"){
      console.log("true");
    }
    else if(numToString.length < 3){
      console.log("false 0");
    }
    else{
      console.log("false" + " " + number);
    }
}
