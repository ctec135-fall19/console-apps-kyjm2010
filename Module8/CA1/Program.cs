using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA1
{
    class Program
    {
       #region Bonus import text file and read/print

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
            
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        #endregion


            Console.WriteLine("This is a string from CA1");
            Console.WriteLine("This is another string from CA1");
            Console.WriteLine("Why not add a third?");
            Console.WriteLine("A fourth?");
            Console.WriteLine("Alright that's enough");
        }
    }
}
