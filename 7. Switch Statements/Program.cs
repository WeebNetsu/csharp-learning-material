int number = 2;

// switch statements are pretty much an alternative to if statements, personal preference which is used
switch (number) {
    case 1:
        System.Console.WriteLine("Answer is 1");
        break; // note break will stop the case
    case 2:
        System.Console.WriteLine("Answer is 2");
        break;
    case 3:
        System.Console.WriteLine("Answer is 3");
        break;
    default:
        System.Console.WriteLine("Answer is not part of switch");
        break;
}

// above if else statement representation would look as follows:
if (number == 11) {
    System.Console.WriteLine("Answer is 1");
} else if (number == 2) {
    System.Console.WriteLine("Answer is 2");
} else if (number == 3) {
    System.Console.WriteLine("Answer is 3");
} else { // default
    System.Console.WriteLine("Answer is not part of switch");
}

switch (number) {
    case 1:
    case 2:
    case 3: // this will trigger on 1, 2 and 3
        System.Console.WriteLine("Answer is 1, 2 or 3");
        break;
    case 4:
        System.Console.WriteLine("Answer is 4");
        break;
    default:
        System.Console.WriteLine("Answer is not part of switch");
        break;
}

// above if else statement representation would look as follows:
if (number == 1 || number == 2 || number == 3) {
    System.Console.WriteLine("Answer is 1, 2 or 3");
} else if (number == 4) {
    System.Console.WriteLine("Answer is 4");
} else {
    System.Console.WriteLine("Answer is not part of switch");
}


string name = "Jack";

switch (name) {
    case "Jack":
        System.Console.WriteLine("Hello, " + name + "!");
        break;
    case "Mike":
        System.Console.WriteLine("YOOO " + name + "!");
        break;
    case "Sarah":
        System.Console.WriteLine("Whaddup, " + name + "!");
        break;
    default:
        System.Console.WriteLine("Do I know you?");
        break;
}