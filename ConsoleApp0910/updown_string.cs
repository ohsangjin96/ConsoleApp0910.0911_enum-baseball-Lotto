using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class updown_string
    {
        static void Main()
        {
            Random rand = new Random();
            bool bFlag = true;
            int success = 0;
            int fail = 0;
            while (bFlag) //문제제출
            {
                int quiz = rand.Next(1, 101);
                int cnt = 0;
                string msg = string.Empty;
                string str;
                Console.WriteLine(quiz);
                while (true) //문제당 5번 시도
                {
                   
                    Console.Write("숫자 입력 (종료: Q):");
                    str = Console.ReadLine();
                    cnt++;

                    if (str.ToLower() == "q")//종료
                    {
                        bFlag = false;
                        break;
                    }

                    int ans = int.Parse(str);

                    if (quiz > ans)
                        msg = "UP";
                    else if (quiz < ans)
                        msg = "DOWN";
                    else if (quiz == ans)//정답이면 while문 빠져나감
                    {
                        msg = "정답";
                        break;
                    }
                    if (msg.Length > 0)
                    {
                        Console.WriteLine(msg);
                    } 
                    if (cnt >= 5)//기회는 다섯번까지
                    {
                        break;
                    }
                }
                if (str == "q")//종료
                {
                    Console.WriteLine("게임을 종료하셧습니다.");
                    break;
                }
                if (msg=="정답")//승리
                {
                    ++success;
                    Console.WriteLine($"축하합니다. {cnt}번 만에 맞추셨습니다.");
                }
                else//패배
                {
                    ++fail;
                    Console.WriteLine($"정답은 {quiz} 입니다.");
                }
            }
            double result = success*1.0/ (success + fail)*100.0;// double/doble 나올수 있게 1.0를 곱해준다.
          
            Console.WriteLine($"당신의 전적은 {success+fail}전 {success}승 {fail}패 {result.ToString("#.##")}%입니다.");
        }
    }
}