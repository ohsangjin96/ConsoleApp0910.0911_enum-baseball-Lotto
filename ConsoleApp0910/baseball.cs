using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0910
{
    class baseball
    {
        static void Main()
        {
            int[] cpu = new int[3]; //컴퓨터
            int[] userunber = new int[3];//사용자
            string yesorno; //Yes Or No 선택 변수
            bool big = true;//제일 큰 while값
            bool small = true;//big while 값 안에 있는 while값
            bool bye = true;//게임을 끝낼건지 알아보는 while값
            int scuccse = 0;//승
            int fail = 0;//패
            Random rand = new Random();//랜덤변수 만들기
          

            while (big)
            {
                #region 컴퓨터 숫자 발굴
                cpu[0] = rand.Next(1, 10);
                int cnt = 1;
                while (cnt < cpu.Length)
                {
                    bool flag = true;
                    int temp = rand.Next(1, 10);
                    for (int i = 0; i < cnt; i++)
                    {
                        if (cpu[i] == temp)
                        {
                            flag = false;
                            break;
                        }

                    }
                    if (flag)
                    {
                        cpu[cnt] = temp;
                        cnt++;
                    }
                }

                #endregion

                #region User 숫자입력 및 야구게임 진행
               
                    int chance = 0;//기회를 나타내는 변수
                    while (small)
                    {
                        string usernum;
                        int num;
                        

                        Console.Write("3자리 숫자를 입력해주세요:");
                        while (true)
                        {

                            usernum = Console.ReadLine();
                            if (usernum.Length != 3)//3자리만 가능하게
                            {
                                Console.WriteLine("3자리를 입력해주세요.");
                                continue;
                            }
                            if (usernum.Contains("0"))//0은 안들어가게
                            {
                                Console.WriteLine("1~9까지의 숫자를 입력해주세요.");
                                continue;
                            }
                            if (!int.TryParse(usernum, out num))//숫자만 들어가게
                            {
                                Console.WriteLine("숫자 3자리를 입력해주세요.");

                            }
                            else
                            {
                                int num1 = num / 100;
                                int num2 = (num / 10) % 10;
                                int num3 = num % 10;
                                if (num1 == num2 || num1 == num3 || num2 == num3)//중복숫자 없게
                                {
                                    Console.WriteLine("중복되지 않는 숫자 3자리를 입력해주세요");
                                }
                                else
                                {
                                    userunber[0] = num1;
                                    userunber[1] = num2;
                                    userunber[2] = num3;
                                    break;
                                }

                            }

                        }

                        int strike = 0, ball = 0;//스트라이크와 볼 변수
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

                        chance++;//기회가 하나씩 사라진다.
                        if (chance == 9)//실패시
                        {
                            Console.WriteLine($"정답은 {cpu[0]}{cpu[1]}{cpu[2]} 입니다");
                            fail++;
                            break;
                        }
                        else if (strike == 3)//성공시
                        {
                            Console.WriteLine("축하합니다." + chance + "번만에 깼습니다.");
                            scuccse++;
                            break;
                        }
                    }
                            while (bye)//계속 할지 여부
                            {
                                Console.WriteLine("그만 하시겠습니까? (Y/N)");
                                yesorno = Console.ReadLine();
                                if (yesorno.ToUpper() == "Y")
                                {
                                    big = false;
                                    small = false;
                                    bye = false;
                                    break;
                                }
                                else if (yesorno.ToUpper() == "N")
                                {
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Y 또는 N를 입력해주세요");
                                    continue;
                                }
                    #endregion
                              }
                          }
            double result = scuccse * 1.0 / (scuccse + fail) * 100.0;
            Console.WriteLine($"승:{scuccse}, 패:{fail} 승률은{result:#.##}");
                    }
                }
                
            
        }
    
