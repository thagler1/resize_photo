using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resize_photo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a complete filepath for an image to resize:\n");
            var image = Console.ReadLine();

            Resizer rezise = new Resizer();
            rezise.PerformReszie(image, 2000, 600);

        }
    }
}
