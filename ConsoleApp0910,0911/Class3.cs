using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Class3
    {

        static void Main()
        {
            string input="";
            do 
            { 
            //사용자가 입력한 단의 구구단 찍기
            Console.WriteLine("출력하고자 하는 구구단은 몇 단?");
            int dan = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{dan}*{i}={dan * i} ");
            }
            
            
            while (true)
            {
                    Console.WriteLine("계속 구구단 출력을 하시겠습니까(y/n)");
                    input = Console.ReadLine().ToLower();
                if (input == "y" || input == "n")
                    break;
                else
                    Console.WriteLine("Y/N 중에서 입력하십시오.");
            }
        }while (input == "y") ;



            //========================================


        }
    }
}
