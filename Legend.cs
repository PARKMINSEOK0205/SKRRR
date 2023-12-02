using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string line = "-----------------------------------------------------"; //const는 변하지 않는 값 한번 할당하면 바꾸기 X
            const int ENDLINE = 42;
            const int DELAY_TIME = 200; 

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(DELAY_TIME);
                Console.Clear();

                ++runA;
                ++runB;
                ++runC;
                ++runD;

                int rndnum = random.Next(0, 4);//0~3

                switch(rndnum)
                {
                    case 0:
                        ++runA;
                        break;
                    case 1:
                        ++runB;
                        break;
                    case 2:
                        ++runC;
                        break;
                    case 3:
                        ++runD;
                        break;

                }

                Console.WriteLine(line);

                for (int i = 0; i < runA; i++)
                   Console.Write(" ");
                    Console.Write("1");

                for(int i = ENDLINE - runA; i >= 0 ; i--)
                    Console.Write(" ");
                Console.WriteLine("|");


                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                    Console.Write("2");

                for (int i = ENDLINE - runB; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                    Console.Write("3");

                for (int i = ENDLINE - runC; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                    Console.Write("4");

                for (int i = ENDLINE - runD; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(line);

                if(runA >= ENDLINE || runB >= ENDLINE || runC >= ENDLINE ||  runD >= ENDLINE)
                {
                    int runNUm = 0;
                    

                    if(runA >= ENDLINE)
                    {
                        runNUm = 1;
                    }
                    else if(runB >= ENDLINE)
                    {
                        runNUm = 2;
                    }
                    else if(runC >= ENDLINE)
                    {
                        runNUm = 3;
                    }
                    else
                    {
                        runNUm = 4;
                    }

                    Console.WriteLine($"결과 {runNUm}우승 !!");

                    Console.Write("다시 하려면 0번 입력 ");
                    if("0" == Console.ReadLine())
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;

                    }
                    else
                    {
                        break;
                    }
                }


            }






        }
    }
}
