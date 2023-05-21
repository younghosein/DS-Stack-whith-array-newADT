using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Example_0
{
    class Program0
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            StackNewAdt0 s = new StackNewAdt0(5);
            s.push(12);
            s.push(1);
            s.push(2);
            s.push(9);
            s.push(3);
            s.push(43);
            s.print();
            Console.Write("\n\nThe Count Of New Adt Is : ");
            int l = s.Len();
            Console.Write(l);
            Console.WriteLine();
            s.pop(true);
            s.pop(true);
            s.pop(false);
            s.pop(true);
            s.print();
            Console.Write("\n\nThe Count Of New Adt Is : ");
            int L = s.Len();
            Console.Write(L);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
