	function onDayButtonClick(args) {
	    var numberWord = +args[]. + ' ',
	        number;

	    switch (numberWord) {
	        case 0:
	            day = "zero";
	            break;
	        case 1:
	            number = "one";
	            break;
	        case 2:
	            day = "two";
	            break;
	        case 3:
	            day = "three";
	            break;
	        case 4:
	            day = "four";
	            break;
	        case 5:
	            day = "five";
	            break;
	        case 6:
	            day = "six";
	            break;
	        case 7:
	            day = "seven";
	            break;
	        case 8:
	            day = "eight";
	            break;
	        case 9:
	            day = "nine";
	            break;
	        default:
	            day = "not a digit";
	            break;
	    }
	}
