using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.B._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rowNum;
                Console.WriteLine("How many rows you want to draw?");
                Console.Write("Input the number here:");
                rowNum = int.Parse(Console.ReadLine());
                for(int row=0;row<rowNum;row++)
                {
                    for(int i=0;i<5;i++)
                    {
                        if(i%2==1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                        
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
