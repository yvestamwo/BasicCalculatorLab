using System;
using System.IO;

namespace consoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            string filename;


            Console.WriteLine("Enter filename");
            filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                Console.WriteLine("enter threshold");


                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempcount = 0;
                using (StreamReader sr = File.OpenText(filename))
                {
                    string line = sr.ReadLine();
                    int temp;
                    while (line != null)
                    {
                        temp = int.Parse(line);
                        sumTemps += 1;
                        tempcount += 1;

                        if (temp >= threshold)
                        {
                            numAbove += 1;
                        }
                        else
                        {
                            numBelow += 1;
                        }
                        line = sr.ReadLine();
                    }
                }
                Console.WriteLine("Temps above =" + numAbove);
                Console.WriteLine("temps below =" + numBelow);
                int average = sumTemps / tempcount;
                Console.WriteLine("Average temp =" + average);
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.WriteLine(System.DateTime.Now.ToString());
                    sw.WriteLine("Temperature above =" + numAbove);
                    sw.WriteLine("Temps below =" + numBelow);
                    sw.WriteLine("Average temp = " + average);
                }
            }       
                   else 
                    {
                        Console.WriteLine("File does not exist");
                    }
                
            
            }
        }
    }

