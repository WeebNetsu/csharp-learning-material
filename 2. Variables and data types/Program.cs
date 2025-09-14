// using System; // generally this would be required for Console.WriteLine, but it is now often
// automatically "imported" in the background with modern C# code
// you can disable this by making enable <ImplicitUsings>enable</ImplicitUsings> disable in the 2. Var...types.csproj file
// whether you keep it enabled or disable it is up to you, it's more a code style choice

// note we are not using name spaces or anything like that in this lesson, since it is optional in modern C# for your main program

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

// below is an example of in how OLD C#, you could write Console.WriteLine without needing to specify "using System;"
System.Console.WriteLine("Someday I would like to change my name to " + name);


// you can also declare variables on the same line if they are the same data type
int x, y, z;
x = 10;
y = 20;
z = 30;

// you can also assign them values in the same manner:
int a = 2,
    b = 4,
    c = 6;


// other data types
char rankInGame = 'B'; // stores 1 letter, note single quotes
double betterPi = 3.1415; // stores decimals
bool hasCar = false;


int regularNumber = 60; // regular whole number, 32 bit
long powerlevel = 987654321L; // 64 bit number
// we specify L since C# will assume a number is an integer, so by specifying L we tell it it will be a long
// note however, while we can store an integer in a long variable, we cannot store a long in an integer (due to size)
// if in doubt use int, long can store more data, but at cost of more memory
Console.WriteLine(int.MaxValue); // allows you to see the min and max values a number data type can store
Console.WriteLine(int.MinValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

float pi = 3.14F; // by default decimals will be double so we need to use F to specify it is a float
double regularPi = 3.1415; // when in doubt between float, decimal and double, use double, more accurate than float, less accurate than decimal
// decimal is very precise, slower than double, but it is great for working with things like money where accuracy is very important
decimal accuratePi = 3.14149M;

// can still show min and max values for them all
Console.WriteLine(double.MaxValue);

// by specifying a "?", you say that this variable may not contain a value and be null
int? possiblyEmpty = null; // null means nothing, empty
System.Console.WriteLine(possiblyEmpty); // notice it prints out an empty line


var auto = 7; // var will automatically determine data type (not recommended)
// Note that if you need to store long, decimal, float or similar values in it that needs a letter
// it may not auto guess it correctly if you do not specify the letter
var longNum = 12348; // it will see it as an int not a long
var long2 = 12345L; // it will see it as a long, since we specified L


const string test = "Hello World";
// test = "new value"; // will throw error, as you cannot change a constant value