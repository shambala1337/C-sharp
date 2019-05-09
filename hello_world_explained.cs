using System;
using System.Collections.Generic; //allow users to create strongly typed collections that provide better 
                                // type safety and performance than non-generic strongly typed collections

using System.Linq;              //provides classes and interfaces that support queries that use Language-Integrated Query (LINQ

using System.Text;          // classes that represent ASCII and Unicode character encodings; abstract base classes
                            //converting blocks of characters to and from blocks of bytes; and a helper class that manipulates
                            //and formats String objects without creating intermediate instances of String.

using System.Threading.Tasks; // simplify the work of writing concurrent and asynchronous code
                              // main types are Task which represents an asynchronous operation that can be waited on and cancelled, 
                              // and Task<TResult>, which is a task that can return a value
                              // The TaskFactory class provides static methods for creating and starting tasks, 
                              // and the TaskScheduler class provides the default thread scheduling infrastructure.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   // comment
            /* multi line */
            Console.WriteLine("Hello Beh");
            Console.Write("Enter your name then press enter: ");


            string name = Console.ReadLine(); // ask for user input

            Console.WriteLine("Hello " + name);
        }
    }
}
