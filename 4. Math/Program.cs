System.Console.WriteLine(10 + 10); // simple addition

int inVar = 10 + 5;
System.Console.WriteLine(inVar);

int usersCount = 10;
System.Console.WriteLine(usersCount);

usersCount = usersCount + 10; // add 10 to original variable
System.Console.WriteLine(usersCount);

usersCount += 5; // same as above but shorter
System.Console.WriteLine(usersCount);

usersCount -= 15; // you can do almost any math simple operation like this
System.Console.WriteLine(usersCount);

usersCount++; // will add 1
System.Console.WriteLine(usersCount);

usersCount--; // will subtract 1
System.Console.WriteLine(usersCount);

--usersCount; // will work the same as above case
System.Console.WriteLine(usersCount);

// but be careful, the order in which the operation executes depends on if the -- or ++ is before or after the value
System.Console.WriteLine(usersCount++); // still same value
System.Console.WriteLine(usersCount); // value has been incremented
// the above happens because we are telling the compiler that we want to console write, then do the addition
System.Console.WriteLine(--usersCount); // value has been decremented - here we tell the compiler that we want to do the subtraction before we console write

// * = times
// / = divide

usersCount = 3 * 3; // note that this will OVERWRITE the value in usersCount
System.Console.WriteLine(usersCount);

usersCount /= 2;
System.Console.WriteLine(usersCount); // actual value is 4.5, but since this is an integer and not a float/double, we will get the truncated value of 4

double score = 35;
score /= 2;

System.Console.WriteLine(score); // now we get the actual value of 17.5 with no truncation

// Modulo helps you get the remainder of a division, so where 9 / 2 = 4 remainder 1, modulo would return 1
System.Console.WriteLine(9 % 2);

// this can be very handy, as a basic example if we % any value by 2, if it returns 1, we have an odd value, otherwise it is even
int oddValue = 15 % 2;
int evenValue = 20 % 2;

System.Console.WriteLine(oddValue); // 1 so odd
System.Console.WriteLine(evenValue); // 0 so even

const int num = 10;

// note because num is a constant, you cannot change the value inside num
// num = 15; // error
// num += 5; // error
System.Console.WriteLine(num + 10); // no error since num is not changed

// note that modulo can be any value, not just 2
System.Console.WriteLine(50 % 11); // 11 22 33 44 -> 6 remainder

// NOTE that math operations do not work the same with strings:
string sentence = "Hello";
sentence += " World";
System.Console.WriteLine(sentence); // will append to string

// you cannot use other operators such as / * - or % on strings