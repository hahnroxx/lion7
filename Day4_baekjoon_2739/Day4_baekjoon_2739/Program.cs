using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Day4_baekjoon_2739
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //    //2 * 1 = 2
            //    //2 * 2 = 4
            //    //2 * 3 = 6
            //    //2 * 4 = 8
            //    //2 * 5 = 10
            //    //2 * 6 = 12
            //    //2 * 7 = 14
            //    //2 * 8 = 16
            //    //2 * 9 = 18

            //    for (int N = 1; N < 10; N++)
            //    {
            //        Console.WriteLine($"2 * {N} = {2 * N}");
            //    }

            //int ClassChoice = 0;

            //Console.WriteLine(" === Character === ");
            //Console.WriteLine("직업 선택: 1.전사, 2.마법사, 3.궁수, 4.도적");
            //ClassChoice = int.Parse(Console.ReadLine());
            //Thread.Sleep(1000);
            //switch (ClassChoice)
            //{
            //    case 1:
            //        Console.WriteLine("\n전사 - 높은 체력과 방어력");
            //        Console.WriteLine("스탯: HP + 50, 공격력 + 10");
            //        Thread.Sleep(500);
            //        break;
            //    case 2:
            //        Console.WriteLine("\n마법사 - 강력한 마법 공격");
            //        Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
            //        Thread.Sleep(500);
            //        break;
            //    case 3:
            //        Console.WriteLine("\n궁수 - 원거리 공격 특화");
            //        Console.WriteLine("스탯: 민첩 + 15, 크리티컬 + 10%");
            //        Thread.Sleep(500);
            //        break;
            //    case 4:
            //        Console.WriteLine("\n도적 - 빠른 속도와 회피");
            //        Console.WriteLine("스탯: 민첩 + 25, 회피율 + 15%");
            //        Thread.Sleep(500);
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 선택입니다! 1~4 중에 골라주세요!");
            //        break;

            //}

            //온도에 따른 옷차림 추천

            int degree = 0;
            Console.Write($"현재 온도는 몇 도인가요? ");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine($"현재 온도: {degree}도");

            if (degree >= 30)
            {
                Console.WriteLine("으악!");
                Thread.Sleep(100);
                Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요");
            }
            else if (degree >= 20 &&  degree <= 29)
            {
                Console.WriteLine("우와!");
                Thread.Sleep(100);
                Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요");
            }
            else if (degree >= 10 && degree <= 19)
            {
                Console.WriteLine("으으으..");
                Thread.Sleep(100);
                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요");
            }
            else if (degree >= 0 && degree <= 9)
            {
                Console.WriteLine("하아...!");
                Thread.Sleep(100);
                Console.WriteLine("추워요! 코트를 입으세요");
            }
            else 
            {
                Console.WriteLine(".....");
                Thread.Sleep(100);
                Console.WriteLine("매우 추워요! 나가지 마세요!");
            }
        }
    }
}
