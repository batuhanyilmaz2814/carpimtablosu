using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimtablosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            for (int i = 1; true ; i++)
            {
                for (j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                    System.Threading.Thread.Sleep(700);




                }
                j = 0;




            }
        }
    }
}
