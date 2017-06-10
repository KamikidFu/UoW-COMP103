using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Command_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader;
                string line;
                Console.WriteLine("Enter your file's path:");
                reader = File.OpenText(Console.ReadLine());
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] data = line.Split(',');
                    for(int i=0;i<data.Length;i++)
                    {
                        int drawNum = int.Parse(data[i]);
                        if(i%2==0)
                        {
                            for(int j=0;j<drawNum;j++)
                            {
                                Console.Write(" ");
                            }
                        }
                        else
                        {
                            for(int k=0;k<drawNum;k++)
                            {
                                Console.Write("#");
                            }
                        }
                    }
                    Console.WriteLine();
                }
                reader.Close();
                Console.ReadKey();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
