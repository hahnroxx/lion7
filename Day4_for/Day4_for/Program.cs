using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day4_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //for 문에 대하여
            //    for (int i = 0; i < 5; i++);
            //    {
            //        Console.WriteLine("Aerondite Deithwen Vitsan Sword Attack");
            //    }
            //int totalGoblin = 5;
            //for(int i=1; i<= totalGoblin; i++)
            //{
            //    Console.WriteLine($"고블린 {i}마리 생성!");
            //}
            //Console.WriteLine($"총 {totalGoblin}마리 생성 완료!");

            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //Thread.Sleep(1000);

            //for (int count = 5; count > 0; count--)
            //{
            //    Console.WriteLine($"{count}...");
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("\n★★★★★ 게임 시작 ★★★★★");

            //for(; ; )
            //{
            //    Console.WriteLine("당신은 방금 죽었습니다.");
            //    Thread.Sleep(100);
            //}

            //검 종류 설정
            //에이론다이트 2%
            //데이스웬 10%
            //비츠산 검 15%
            //투생 기사의 강철검 5%
            //엑스칼리버 28
            //무딘 검 40
            
            string sword = "무한의 대검";

            Console.WriteLine("당신은 20번 뽑기가 가능합니다.");
            Console.WriteLine("지금 실행합니다!");
            
            Random rand = new Random();

            int random = 0;

            for (int gacha = 0; gacha < 20; gacha++)
            {
                random = rand.Next(1, 101);

                if (random >= 1 && random <= 2)
                {
                    sword = "에이론다이트";
                }
                else if (random >= 3 && random <= 10)
                {
                    sword = "데이스웬";
                }
                else if (random >= 11 && random <= 31)
                {
                    sword = "투섕 강철 검";
                }
                else if (random >= 32 && random <= 60)
                {
                    sword = "칼리버";
                }
                else
                {
                    sword = "무딘 검";
                }
                Console.WriteLine($"당신은 바위에서 {sword}을(를) 뽑아냈습니다!");
                if (sword == "에이론다이트")
                {
                    Console.WriteLine("축하합니다!");
                }
                Thread.Sleep(50);
            }

            }
    }
}
