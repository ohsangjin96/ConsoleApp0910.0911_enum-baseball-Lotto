using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class baseball_ex
    {
        static void Main()
        {
            int[] cpu = new int[3] { 1, 2, 5 };
            int[] userunber = new int[3] { 1, 5, 7 };

            
      
                int strike = 0, ball = 0;
                for (int i = 0; i < userunber.Length; i++)
                {
                    for (int j = 0; j < cpu.Length; j++)
                    {
                        if (userunber[i] == cpu[j])
                        {
                            if (i == j) // 인덱스(순서)까지 같은것
                                strike++;
                            else // 숫자만값은것
                                ball++;
                        }

                    }
                }
                Console.WriteLine($"{strike}스트라이크, {ball}볼");
            if (strike == 3)
                {
                    Console.WriteLine("축하합니다.");
                    
                }
            
        }
    }
}
