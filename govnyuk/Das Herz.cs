using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication2
{
    class Program
    {
       static void Main(string[] args)
       {
           float y,x, z, f;
           for (y =1.5f; y > -1.5f; y -= 0.1f)
           {
              for (x = -1.5f; x < 1.5f;x += 0.05f)
              {
                 z = x * x + y * y - 1;
                 f = z * z * z - x * x * y * y * y;
                 Console.Write(f <= 0.0f ? ".:-=+*#%@"[(int)(f* -8.0f)] : ' ');
              }
              Console.WriteLine();
           }
          Console.ReadLine();
 
       }
    }
}