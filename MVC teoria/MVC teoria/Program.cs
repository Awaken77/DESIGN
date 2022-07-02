using System;

namespace MVC_teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Controllers.UsersController().Display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
