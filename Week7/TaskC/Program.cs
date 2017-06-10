using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declear varible
            int rowNum = 0;
            Console.WriteLine("How many rows you want?");
            //Get the value
            rowNum = int.Parse(Console.ReadLine());
            try
            {
                //Draw each rows
                for (int i = 0; i < rowNum; i++)
                {
                    //Draw each character
                    for (int n = 0; n < rowNum; n++)
                    {
                        //Third row to draw =
                        if ((i + 1) % 3 == 0)
                        {
                            Console.Write("=");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch(Exception ex            )
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
