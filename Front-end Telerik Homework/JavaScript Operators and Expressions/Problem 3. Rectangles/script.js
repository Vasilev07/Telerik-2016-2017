function rectangle(args) {
    var width = args[0];
    var height = args[1];
    console.log((parseFloat(width * height).toFixed(2)) + ' ' + ((parseFloat(2 * width) + (2 * height)).toFixed(2)));
}
