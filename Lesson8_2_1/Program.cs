using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/For lesson 8/text_files/text8_2.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("десять рандомных чисел -");
                {
                    int[] array = new int[10];
                    Random random = new Random();
                    int S = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = random.Next(0, 10);
                        S += array[i];
                        sw.Write("{0}", array[i]);
                        sw.WriteLine();
                    }
                    //sw.WriteLine();
                    //sw.WriteLine("Сумма чисел - ");
                    //sw.WriteLine(S);                  - это небыло условием, но мне понравилось)
                    using (StreamReader sr = new StreamReader(path))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }
                    //Console.WriteLine();
                    // Console.WriteLine("Сумма чисел из файла -");
                    //Console.WriteLine(S);                         - должно работать
                    Console.ReadKey();
                }
                                 
            }
        }
    }
}

    
                
            



        
    

