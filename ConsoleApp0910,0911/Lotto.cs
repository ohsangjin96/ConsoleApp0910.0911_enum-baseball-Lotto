using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Lotto
    {
        static void Main()
        {
            int[] lotto = new int[6];
            Random rand = new Random();

            int cnt = 1;
             lotto[0] = rand.Next(1, 47);//0번째는 중복검사를 할 필요가 없다.
            while (cnt<lotto.Length)
            {
                int temp = rand.Next(1, 47);
                bool bFlag = true;//기본값은 중복이 아닌것으로 설정
                //뽑은 난수가 앞부분의 값들과 중복이 되는지 체크
                for (int i = 0; i < cnt; i++)
                {
                    if (lotto[i] == temp)//중복일 경우
                    {
                        bFlag = false;
                        break;
                    }
                }
                
                    if (bFlag)//중복이 아닌경우
                    {
                        lotto[cnt] = temp;
                        cnt++;
                    }
                
            }
            foreach (int num in lotto)
            {
                Console.Write(num + ",");
            }
           
        }
    }
}
