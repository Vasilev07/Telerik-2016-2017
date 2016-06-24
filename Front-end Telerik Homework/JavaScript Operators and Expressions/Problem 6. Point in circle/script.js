function solve(args){
  var x = +args[0];
      y = +args[1];
      radius = 2;
      point = Math.sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0)).toFixed(2);

      if (point <= 2){
        console.log('yes'+ ' ' + point);
      }
      else{
        console.log('no' + ' ' + point);
      }

}
