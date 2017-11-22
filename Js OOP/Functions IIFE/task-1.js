/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve(){
	return function sum(numbers) {
		if(numbers === undefined) {
			throw new Error('The array cannot be undefined.');
		} else if(!numbers.length){
			return null;
		} else {
			if(!numbers.every(function(num) {
					return num == Number(num);
				})) {
				throw new Error('All elements must be numbers.');
			}
	
			return numbers.reduce(function(currentSum, number) {
				return currentSum + +number;
			}, 0);
		}
	}
}

module.exports = solve;

