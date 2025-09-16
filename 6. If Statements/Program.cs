// you still have other comparison operators such as == >= <= !=
bool
    a = true,
    b = false,
    c = !true, // false
    l = !!true, // true
    d = 1 == 2, // false
    e = 5 == 5, // true
    f = 10 != 6, // true,
    g = 20 > 70, // false
    h = 20 < 70, // true
    i = 70 > 70, // false
    j = 70 >= 70, // true
    k = 70 <= 70;// true

if (true) {
    System.Console.WriteLine("This will always execute");
}

if (false) {
    System.Console.WriteLine("This will never execute");
}

if (!false) {
    System.Console.WriteLine("This will always execute (not false)");
}

const int
    DRINKING_AGE = 21,
    MAX_DRINKING_AGE = 55;

int age = 18;
bool isBirthday = true;

if (age < DRINKING_AGE) {
    System.Console.WriteLine("You are too young, go away");
}

age = 87;

if (age > DRINKING_AGE) {
    System.Console.WriteLine("You may enter");

    // you can have nested if statements
    if (isBirthday) {
        System.Console.WriteLine("First drink is on us!");
    }
}


if (age < DRINKING_AGE) {
    System.Console.WriteLine("You are too young, go away");
} else { // will always execute if previous check does not
    System.Console.WriteLine("You may enter");
}

if (age < DRINKING_AGE) {
    System.Console.WriteLine("You are too young, go away");
} else if (age > MAX_DRINKING_AGE) { // will only execute if true and previous statement did not
    System.Console.WriteLine("Please! Spare your liver!");
} else {
    System.Console.WriteLine("You may enter");
}

if (age > DRINKING_AGE) {
    System.Console.WriteLine("This will run");
}

if (age > MAX_DRINKING_AGE) {
    System.Console.WriteLine("This will also run if true, since there was no else statement");
}

// Note the above could also be done like this:

if (age < DRINKING_AGE) {
    System.Console.WriteLine("You are too young, go away");
} else {
    // the two ways of doing if else are the same, but one may look a bit messier than the other
    if (age > MAX_DRINKING_AGE) {
        System.Console.WriteLine("Please! Spare your liver!");
    } else {
        System.Console.WriteLine("You may enter");
    }
}

System.Console.Write("Enter name: ");
string? name = Console.ReadLine();

System.Console.Write("Enter age: ");
string? inputAge = Console.ReadLine();

int convertedAge = Convert.ToInt32(inputAge);

if (name == "Jack") {
    System.Console.WriteLine("You are the owner! Can't be drinking on the job!");
} else if (convertedAge < 60) { // converted to int since > < >= and <= does not work on strings
    System.Console.WriteLine("Double price for you");
}

if (name == "Jack" || name == "Tim") { // or
    System.Console.WriteLine("Remember to close the door after entering!");
}

if (name == "Mark" && convertedAge > 21) { // and
    System.Console.WriteLine("We know you're lying Mark. Buzz off");
}

if ((name == "Jack" || name == "Tim") && convertedAge < 30) { // note the brackets for the or statement
    System.Console.WriteLine("Keep dreaming!");
}

if ((convertedAge > DRINKING_AGE && convertedAge < MAX_DRINKING_AGE) || convertedAge == 70) { // note brackets
    System.Console.WriteLine("Enjoy yourself");
}