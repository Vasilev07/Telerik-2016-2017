var number = 8;
var result = (typeof number === 'number');
console.log(result);

var name = "Gosho";
var result = (typeof name === 'string');
console.log(result);

var obj = {};
var result = (typeof obj === 'object');
console.log(result);

var array = [];
var result = (typeof array === 'object');
console.log(result);

var declared;
var result = (typeof declared === 'undefined');
console.log(result);
