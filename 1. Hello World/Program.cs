// you can generate a new console program with `dotnet new console -o MyApp` on Linux

// you don't need to specify a namespace in such a basic program, you can just start writing
// Console.WriteLine("Hello, World!");

// 2nd option is to specify a namespace with a main program inside it
// project name (however will work fine if something random)
namespace _1._Hello_World {
    class Program {
        // main method similar to C++ and Java
        static void Main(string[] args) {
            /* 
            Multi
            line
            comment
             */
            Console.WriteLine("Hello, World!"); // print to console (; is required)

            Console.Write("Your name is "); // this will not make the next console write go to the next line
            Console.WriteLine("Mike");

            // if not using a terminal (like we are on Linux) and you console is just opening and closing
            // (looking at you windows), then you can attach the below so it waits for input before closing
            // the window
            // Console.ReadLine();
        }
    }
}