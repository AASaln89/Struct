using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");
            float k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            float b = Convert.ToInt32(Console.ReadLine());
            line line = new line() { k = k, b = b };
            line.Root(k, b, out float x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
    struct line
    {
        public float k;
        public float b;
        public static void Root(float k, float b, out float x)
        {
            x = 0;
            x = -b / k;
            if (k * x + b == 0)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
