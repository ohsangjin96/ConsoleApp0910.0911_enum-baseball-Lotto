using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Class2
    {
        
        static void Main()
        {
            //int a = 0;
            //for (int i=1; i<10; i++)
            //{
            //    a = 3 * i;
            //    Console.WriteLine("3*{0}={1}",i,a);
            //}
            int sum = 0;
            //for(int i=1; i<101; i++)
            //{
            //   sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //sum = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }

            //}
            //Console.WriteLine(sum);
          for(int i=2; i<=100;)
            {
                sum = sum + i;
                i = i + 2;
            }
            Console.WriteLine(sum);
            //1부터 100까지의 2의 배수이고 5의 배수를 출력하시오
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);



            //1부터 100까지의 3의 배수이거나 5의 배수를 출력하고, 합도 출력해주세여
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i+" ");
                  
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

            sum = 0;

        }
    }
}
