using System;

namespace Fabryka_abstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            Client entrepreneur = new Client(new ElegantClothesFactory());
            Console.WriteLine($"Entrepreneur:{entrepreneur.DescribeYourClothes()}");

            Client student = new Client(new CasualClothesFactory());
            Console.WriteLine($"Student: {student.DescribeYourClothes()}");

            Console.ReadKey();
        }
    }
}
