using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class RockPaperScissors
    {
        static void Main()
        {
            Random rand = new Random();
            bool choice = true;

            while (choice)
            {
              
                bool choice1 = true;
                Console.WriteLine("가위,바위,보 중에 한가지를 선택해주세요:가위(S), 바위(R), 보(P)");
                int cpu = rand.Next(1, 3);
                string player = Console.ReadLine();  //가위:1, 바위:2, 보:3
                if (player.ToUpper() == "S")
                {
                    if (cpu == 1)
                        Console.WriteLine("무승부!!");
                    else if (cpu == 2)
                        Console.WriteLine("CPU 승!!");
                    else
                        Console.WriteLine("Player 승!!");


                }
                else if (player.ToUpper() == "R")
                {
                    if (cpu == 1)
                        Console.WriteLine("Player 승!!");
                    else if (cpu == 2)
                        Console.WriteLine("무승부!!");
                    else
                        Console.WriteLine("CPU 승!!");

                }
                else if (player.ToUpper() == "P")
                {
                    if (cpu == 1)
                        Console.WriteLine("CPU 승!!");
                    else if (cpu == 2)
                        Console.WriteLine("Player 승!!");
                    else
                        Console.WriteLine("무승부!!");
                }
                else
                {
                    Console.WriteLine("S,P,R 만 선택해주세요");

                }
                while (choice1)
                {
                    Console.WriteLine("다시 하시겠습니까?(Y/N)");
                    string input = Console.ReadLine();

                    if (input.ToUpper() == "Y")
                    {
                        choice = true;
                        choice1 = false;
                       
                    }
                    else if (input.ToUpper() == "N")
                    {

                        choice = false;
                        choice1 = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("다시입력해주세요");
                        choice1 = true;
                    }
                }
            }
        }
    }

}
