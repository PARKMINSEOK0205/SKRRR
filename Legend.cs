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
        const string line = "-----------------------------------------------------"; //const는 변하지 않는 값 한번 할당하면 바꾸기 X
        const int ENDLINE = 42;
        const int DELAY_TIME = 200;

        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;


        static void ClearScreen()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void Process(ref Random random)
        {
            ++runA;
            ++runB;
            ++runC;
            ++runD;

            int rndnum = random.Next(0, 4);//0~3

            switch (rndnum)
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
        }

        static void UpdateScreen()
        {
            Console.WriteLine(line);

            for (int i = 0; i < runA; i++)
                Console.Write(" ");
            Console.Write("1");

            for (int i = ENDLINE - runA; i >= 0; i--)
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
        }

        static bool CheckResult()
        {
            if (runA >= ENDLINE || runB >= ENDLINE || runC >= ENDLINE || runD >= ENDLINE)
            {
                int runNUm = 0;


                if (runA >= ENDLINE)
                {
                    runNUm = 1;
                }
                else if (runB >= ENDLINE)
                {
                    runNUm = 2;
                }
                else if (runC >= ENDLINE)
                {
                    runNUm = 3;
                }
                else
                {
                    runNUm = 4;
                }

                Console.WriteLine($"결과 {runNUm}우승 !!");

                Console.Write("다시 하려면 0번 입력 ");
                if ("0" == Console.ReadLine())
                {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;
                    return true;//0값이 들어오면 다시시작
                }
                else
                {
                    return false;//0값이 들어오지ㅏ 않으면 false를 반환하여 프로그램 종료
                }
            }
            return true;//무조건 리턴을 해줘하는데 이 코드를 넣지 않으면 리턴해주지 않는 상황이 발생할수있다 if문 조건에 맞지 않으면 true반환하여 계속if조건체크
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {

                ClearScreen();

                Process(ref random); 

               UpdateScreen();

               if(CheckResult() == false)
                {
                    break;
                }
            }

        }
    }
}

