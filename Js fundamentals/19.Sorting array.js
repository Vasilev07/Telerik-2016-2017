function solve (args) {
    let     arrayLength = +args[0],
        array = args[1].split(' ').map(Number);

    var sorted = array.sort(function (a, b) {
        return a - b
    });

    return sorted.join(' ');
}