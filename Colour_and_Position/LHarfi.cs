using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colour_and_Position
{
    internal class LHarfi
    {
        public int Xkoordinat;
        public int Ykoordinat;
        public int yukseklik;
        public int genislik;

        public LHarfi()
        {
            Xkoordinat = Convert.ToInt32(Console.ReadLine());
            Ykoordinat = Convert.ToInt32(Console.ReadLine()); ;
            yukseklik = Convert.ToInt32(Console.ReadLine()); ;
            genislik = Convert.ToInt32(Console.ReadLine()); ;
        }
        public void Goster()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
       
            for (int i = 0; i < yukseklik; i++)
            {
                Console.SetCursorPosition(Xkoordinat, Ykoordinat+i);
                Console.WriteLine("  ");
            }
            
            for (int i = 0; i < genislik; i++)
            {
                Console.SetCursorPosition(Xkoordinat+i, Ykoordinat+yukseklik);
                Console.Write("   ");
            }
            Console.ResetColor();
        }
    }
}
