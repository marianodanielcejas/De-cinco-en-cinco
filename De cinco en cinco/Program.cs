using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_cinco_en_cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i = i + 5)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
