function allocateArr(args) {
    var n = +args[0],
        arr = [],
        i;
    for (var i = 0; i < n; i += 1) {
        arr[i] = i * 5;
        console.log(arr[i]);
    }
}
