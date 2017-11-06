function hexToDec(hex) {
    let result = 0;
    let digitValue;
    hex = hex.toLowerCase();
    for (let i = 0; i < hex.length; i++) {
        digitValue = '0123456789abcdefgh'.indexOf(hex[i]);
        result = result * 16 + digitValue;
    }
    return result;
}

console.log(hexToDec('FE'));