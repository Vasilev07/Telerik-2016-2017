function quadricEq(value) {
    var a = +value[0],
        b = +value[1],
        c = +value[2],
        d = (b * b) - (4 * a * c),
        x1,
        x2;
    if (d < 0) {
        return 'no real roots';
    } else if (!d) {
        x1 = -b / (2 * a);
        return 'x1=x2=' + x1.toFixed(2);
    } else {
        x2 = (-b - Math.sqrt(d)) / (2 * a);
        x1 = (-b + Math.sqrt(d)) / (2 * a);
      return 'x1=' + x1.toFixed(2) + ';' + ' x2=' + x2.toFixed(2);
    }

}
console.log(quadricEq(['2', '5', '-3']));
console.log(quadricEq(['-1', '3', '0']));
console.log(quadricEq(['-0.5', '4', '-8']));
console.log(quadricEq(['5', '2', '8']));
console.log(quadricEq(['0.2', '9.572', '0.2']));
