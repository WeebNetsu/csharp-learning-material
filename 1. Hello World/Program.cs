// you can generate a new console program with `dotnet new console -o MyApp` on Linux

// you don't need to specify a namespace in such a basic program, you can just start writing
// Console.WriteLine("Hello, World!");

// 2nd option is to specify a namespace with a main program inside it
namespace _1._Hello_World // project name (however will work fine if something random)
{
    class Program
    {
        static void Main(string[] args) // main method similar to C++ and Java
        {
            /* 
            Multi
            line
            comment
             */
            Console.WriteLine("Hello, World!"); // print to console (; is required)

            // if not using a terminal (like we are on Linux) and you console is just opening and closing
            // (looking at you windows), then you can attach the below so it waits for input before closing
            // the window
            // Console.ReadLine();
        }
    }
}