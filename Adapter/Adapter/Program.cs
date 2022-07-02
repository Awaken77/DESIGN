using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setting input for DVI Monitor!");
            VgaGraphicsCard vgaGraphicsCard = new VgaGraphicsCard();
            DviMonitor dviMonitor = new DviMonitor();
            VgaGraphicsCardAdapter vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());
            Console.ReadLine();
        }
    }
}
