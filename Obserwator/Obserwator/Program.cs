using System;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("Alpha News Agency");
            weatherStation.Attach(agency1);

            NewsAgency agency2 = new NewsAgency("Omega News Agency");
            weatherStation.Attach(agency2);

            weatherStation.Temperature = 31.2f;
            weatherStation.Temperature = 28f;
            weatherStation.Temperature = 46.2f;
            weatherStation.Temperature = 15.2f;

            Console.ReadLine();


        }
    }
}
