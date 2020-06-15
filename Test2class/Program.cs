using System;

namespace Test2class
{
    class Program
    {
        //metodo : Entry Point
        static void Main()
        {
            Tests t = new Tests();
            t.Test1();
            t.Test2();
            t.TearDown();
            Console.WriteLine("End of program.");
            //descartar uso de input
            _ = Console.ReadLine();
        }
    }
}
