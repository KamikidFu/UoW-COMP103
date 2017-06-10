using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowNum;
            Console.WriteLine("How many rows you want to draw?");
            rowNum = int.Parse(Console.ReadLine());
            for(int i=0;i<rowNum;i++)
            {
                for(int n=0;n<rowNum;n++)
                {
                    if(i==n)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
