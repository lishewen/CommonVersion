using ClassLibrary4NetCore;
using ClassLibrary4NetStandard;
using System;

namespace CommonVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MyClass4NetCore.Hello());
            Console.WriteLine(MyClass4NetStandard.Hello());

            Console.ReadLine();
        }
    }
}
