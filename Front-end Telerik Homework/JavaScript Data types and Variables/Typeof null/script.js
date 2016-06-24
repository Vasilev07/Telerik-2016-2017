var a = null;
var result = (typeof a === 'undefined');
console.log(result);
//false

var a = null;
var result = (typeof a === 'object');
console.log(result);
//true

var undef;
var result = (typeof undef === 'undefined');
console.log(result);
//true
