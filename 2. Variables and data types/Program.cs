// note we are not using name spaces or anything like that in this lesson, since it is optional

string name = "Max"; // Note double quotes
int age; // optionally you can define an empty variable and give it a value later
         // Console.WriteLine(age); // this will throw an error because age was not yet defined
age = 30; // number, no quotes
Console.WriteLine(age); // will not throw an error because age is defined

Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old");
// you need to do the below in brackets other wise a string will be added to age and then 1 will be added
// which will make it 301 instead of 31, by specifying brackets, we are saying that it should do the math
// before converting anything to a string
Console.WriteLine("Next year I will be " + (age + 1) + " years old");
name = "Jack";
Console.WriteLine("Someday I would like to change my name to " + name);

// other data types
char rankInGame = 'B'; // stores 1 letter, note single quotes
float pi = 3.14F; // by default decimals will be double so we need to use F to specify it is a float
double betterPi = 3.1415; // when in doubt between float, decimal and double, use double, more accurate than float, less accurate than decimal
decimal bestPi = 3.14149M;
bool hasCar = false;

const string test = "Hello World";
// test = "new value"; // will throw error, as you cannot change a constant value