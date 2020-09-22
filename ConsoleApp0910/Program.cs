using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while (true)
            {
                //Parse() 메서드는 문자열을 숫자로 변환
                //System.Convert 클래스를 사용해서 모든타입을 내가 원하는 타입으로 변환
                //input=int.Parse(Console.ReadLine());
                Console.WriteLine("1~10까지의 숫자를 입력하세요:");
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 1 || input > 10)
                {
                    Console.WriteLine("1~10 사이의 정수를 입력하세요.");
                }
            }
            Console.WriteLine(input);
        }
    }
}
