namespace _5._User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // first way to get user input is with args, these are passed in when you run via the terminal
            // dotnet run hello world
            // NOTE this works both with and without needing to specify static void Main(string[] args)
            // since new C# will auto wrap a program with it

            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);

            // option 2
            Console.WriteLine("Your Name:");
            string? userName = Console.ReadLine(); // note input may be null

            Console.WriteLine("Your name is: " + userName);

            // not if following along without using a terminal/console, remember to have another readline at the end of
            // the program to keep the console open

            Console.WriteLine(); // this is a valid piece of code, it will print out an empty line to the screen

            // to get the input on the same line you can use write instead of write line
            Console.Write("Your Age: ");
            string? userAge = Console.ReadLine(); // note even though we request a number, consol input will always be a string
            Console.WriteLine("Your age is: " + userAge);

            // you can use convert, as learned in working with strings, to make user age an integer
            int age = Convert.ToInt32(userAge);
            Console.WriteLine("You will be " + (age + 10) + " in 10 years");

            // you can shorten the whole upper portion by doing it in one line
            Console.Write("What is your average grade: ");
            double averageGrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your average grade: " + averageGrade);

            // note inputs that cannot be converted will throw errors, such as "hello" when you should enter your age
            // we'll handle error handling at a later stage
        }
    }
}