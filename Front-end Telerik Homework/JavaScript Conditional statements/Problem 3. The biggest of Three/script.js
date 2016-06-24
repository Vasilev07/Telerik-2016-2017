function sortNumbers(args) {

    var firstNum = +args[0] + '';
    var secondNum = +args[1] + '';
    var thirdNum = +args[2] + '';

    if (firstNum >= thirdNum && firstNum >= secondNum) {
            if (secondNum >= thirdNum) {
                return firstNum + ' ' + secondNum + ' ' + thirdNum;
            } else {
                return firstNum + ' ' + thirdNum + ' ' + secondNum;
            }
        } else if (secondNum >= firstNum && secondNum >= thirdNum) {
            if (firstNum >= thirdNum) {
                return secondNum + ' ' + firstNum + ' ' + thirdNum;
            } else {
                return secondNum + ' ' + thirdNum + ' ' + firstNum;
            }
        } else if (thirdNum >= secondNum && thirdNum >= firstNum) {
            if (secondNum >= firstNum) {
                return thirdNum + ' ' + secondNum + ' ' + firstNum;
            } else {
                return thirdNum + ' ' + secondNum + ' ' + firstNum;
            }
        }
      }
