using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionA_TimeTableGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try Catch
            try
            {
                //Declear varible
                int min, max,i,n,timesValue;
                //Get value
                Console.WriteLine("Input your minimum number:");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your maximum number:");
                max = int.Parse(Console.ReadLine());
                //IF THEN
                if(max>=min)
                {
                    //FOR each value from min to max
                    for(i= min;i<= max;i++)
                    {
                        Console.WriteLine(i.ToString()+" Times Table:");
                        //FOR each value from 1 to 9
                        for(n=1;n<=9;n++)
                        {
                            //GET Times value
                            timesValue = i * n;
                            //Display Times values
                            Console.WriteLine(" "+n.ToString() + " * " + i.ToString() + " = " + timesValue.ToString());                            
                        }
                    }
                }
                else
                {
                    //Display error message
                    Console.WriteLine("Input error!");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                //Display error message
                Console.WriteLine(ex.Message);
                
            }

        }
    }
}
