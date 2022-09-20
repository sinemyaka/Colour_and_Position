using System;

namespace Colour_and_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LHarfi harf = new LHarfi();
            while(true)
            {
                //harf.Xkoordinat = Convert.ToInt32(Console.ReadLine());
                harf.Goster();
                
                ConsoleKeyInfo tus = Console.ReadKey();
                if (tus.Key == ConsoleKey.A)
                   harf.Xkoordinat--;
                if (tus.Key == ConsoleKey.D)
                    harf.Xkoordinat++;
                if (tus.Key == ConsoleKey.W)
                    harf.Ykoordinat--;
                if (tus.Key == ConsoleKey.S)
                    harf.Ykoordinat++;

            }
            
            

            Console.ReadKey();
        }
    }
}
