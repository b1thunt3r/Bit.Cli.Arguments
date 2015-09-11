
using System;

namespace Bit.Cli.Arguments.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = new Arguments(args);

            Console.WriteLine(arguments.Bool1);
            Console.ReadKey();
        }
    }
}
