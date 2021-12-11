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

            string path = "Logs2/SumRandom.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            // DirectoryInfo directory = new DirectoryInfo(path);
            // if(!directory.Exists)
            {
            //    directory.Create();
                
            }
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
                    }

                  sw.WriteLine();
                  sw.WriteLine("Сумма чисел - ");
                  sw.WriteLine(S);      //- это не было условием, но как вариант записи в файл )
                    {
                        
                            using (StreamReader sr = new StreamReader(path))       // - тут проблема - пишет, что занят другим процессом, пробовала по разному, менять директории, но нет)
                            {
                                Console.WriteLine(sr.ReadLine());

                            }
                        // соответственно, остальное работает, сумму из файла можно считать из формулы выше, но из за проблемы считывания нет смысла подставлять ниже
                     Console.WriteLine();
                     Console.WriteLine("Сумма чисел из файла -");
                     Console.WriteLine(S);                        
                     Console.ReadKey();
                    }

                }
            }
        }
    }
}


    
                
            



        
    

