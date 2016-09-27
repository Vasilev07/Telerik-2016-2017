function compare(args) {
    var arr = args[0].split('\n'),
      wordOne = String(arr[0]),
      wordTwo = String(arr[1]);
      if (wordOne > wordTwo) {
        console.log('>');
      }else if (wordOne < wordTwo){
        console.log('<');
      }else if (wordOne === wordTwo) {
        console.log('=');
      }
}
