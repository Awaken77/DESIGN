using System;

namespace chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nHello World!");
            Handle1 handle1 = new Handle1();
            Handle2 handle2 = new Handle2();

            handle1.SetHandler(handle2);

            handle1.HandleRequest("This is my argument");
            handle1.HandleRequest(100);
            handle1.HandleRequest(100.0f);

            Console.ReadLine();
        }
    }
}
