function thirBit(bit){
  var x = +bit[0];
      y = (x >>>3).toString(2);
      console.log(y[y.length - 1]);
}
