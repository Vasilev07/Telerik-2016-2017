function maxValueOfArray(array) {
    let maxValue = 0;
    array.forEach((value) => maxValue = Math.max(maxValue,value));
    return maxValue;
}
console.log(maxValueOfArray.name);
console.log(maxValueOfArray.length);
console.log((function(){}).name);
console.log(maxValueOfArray([1, 2, 3, 4, 5]));