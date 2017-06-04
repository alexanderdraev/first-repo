using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int photoNumber = int.Parse(Console.ReadLine());
            int dayTaken = int.Parse(Console.ReadLine());
            int monthTaken = int.Parse(Console.ReadLine());
            int yearTaken = int.Parse(Console.ReadLine());
            int hoursTaken = int.Parse(Console.ReadLine());
            int minutesTaken = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}", dayTaken, monthTaken,
                yearTaken, hoursTaken, minutesTaken );

            if (size < 1000)
            {
                Console.WriteLine("Size: {0}B", size);
            }
            else if (size / 1000 < 1000)
            {
                Console.WriteLine("Size: {0}KB", size / 1000);
            }
            else
            {
                Console.WriteLine("Size: {0}MB", size / 1000000);
            }

            if (width < height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)",width,height);
            }
            else if (width > height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)",width,height);
            }
            else
            {
                Console.WriteLine("Resolution: {0}x{1} (square)",width,height);
            }
        }
    }
}
        