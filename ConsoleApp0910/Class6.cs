using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class Class6
    {
        //열거형(enum) 정의(1)=>클래스레벨로 간주, 같은 네임스페이스 안의 여러개의 클래스들이 모두 열거형을 사용하고자 할때
        //열거형(enum) 정의(2)=>해당 클래스를 통해서만 열거형을 사용하고자 할때
        enum MyMessage { Yes, No, Confirm, cancel, ok};
        static void Main()
        {
            int i = 10;
            MyMessage msg = MyMessage.Yes;
            Console.WriteLine(msg);

            if (msg == MyMessage.ok)
                Console.WriteLine("OK를 선택하셨습니다.");
            else if(msg==MyMessage.Yes)
                Console.WriteLine("Yes를 선택하셨습니다.");
                    
        }
    }
}
