using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Class5
    {
        enum GameMessage { NONE, UP, DOWN, CORRECT, QUIT } //정의

        static void Main()
        {
            Random rand = new Random();
            bool bFlag = true;
            int success = 0;
            int fail = 0;

            while (bFlag) //문제제출
            {
                int quiz = rand.Next(1, 101); //문제
                Console.WriteLine("문제" + quiz);

                int cnt = 0; //시도 횟수
                GameMessage msg = GameMessage.NONE; //시도당 결과

                while (true) //문제당 5번 시도
                {
                    Console.Write("숫자 입력 (종료: Q):");
                    string str = Console.ReadLine();
                    cnt++;

                    if (str.ToLower() == "q")
                    {
                        msg = GameMessage.QUIT;
                        bFlag = false;
                        break;
                    }

                    int ans = int.Parse(str);

                    // 처리로직 - UP, DOWN, 정답                    
                    if (quiz > ans)
                    {
                        msg = GameMessage.UP;                     
                    }
                    else if (quiz < ans)
                    {
                        msg = GameMessage.DOWN;
                    }
                    else if (quiz == ans)
                    {
                        msg = GameMessage.CORRECT;
                        break;
                    }

                    // 1번 시도할때 마다 결과출력
                    if (msg != GameMessage.NONE)
                    {
                        Console.WriteLine(msg);
                    }

                    if (cnt >= 5)
                    {
                        break;
                    }
                }
                
                //한 문제가 종료되었을때
                if (msg == GameMessage.CORRECT)  //성공했을떄
                {
                    success ++;
                    Console.WriteLine($"축하합니다. {cnt}번 만에 맞추셨습니다.");                    
                }
                else if (msg != GameMessage.QUIT)   //실패했을떄
                {
                    fail ++;
                    Console.WriteLine($"정답은 {quiz} 이었습니다.");
                }
            }

            //승률을 출력
            double result = success * 1.0 / (success + fail) * 100;
            Console.WriteLine($"당신의 전적은 {success + fail}전 {success}승 {fail}패 {result.ToString("#.##") }% 입니다.");
            
        }
    }
}
