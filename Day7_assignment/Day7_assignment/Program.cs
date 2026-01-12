using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day7_assignment
{
    internal class Program
    {
        static float GetAverage(int[] nums)
        {
            
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return (float)sum / nums.Length;
        }

        static void Grade(int a)
        {
            int maxScore = 100;
            if (a <= maxScore && a >= 81)
            {
                Console.WriteLine("A등급");
            }
            else if (a <= 80 && a >= 61)
            {
                Console.WriteLine("B등급");
            }
            else if (a <= 60 && a >= 41)
            {
                Console.WriteLine("C등급");
            }
            else if (a <= 40 && a >= 21)
            {
                Console.WriteLine("D등급");
            }
            else
            {
                Console.WriteLine("E등급");
            }
            
        }
        
        static bool IsPrimeNum(int PrimeNum)
        {
            if(PrimeNum < 2)
                    return false;
            for (int i = 2; i < PrimeNum; i++)
            {
                if (PrimeNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        static bool LevelUp(int NowExp ,int GetExp)
        {
            int MaxExp = 1000;
            if (GetExp + NowExp >= MaxExp)
            {
                
                Console.WriteLine($"경험치를 {GetExp}p 얻었습니다!");
                Console.WriteLine("레벨 업! 축하합니다.");
                return true;
            }
            else
            {
                
                Console.WriteLine($"경험치를 {GetExp}p 얻었습니다!");
                Console.WriteLine($"레벨 업까지 {MaxExp - (GetExp + NowExp)}p");
                return false;
            }
            
        }

        static bool ItemEnhance(int ItemLevel)
        {
            Random rnd = new Random();
            int UpRate = 100 - ItemLevel * 5;
            if (UpRate < 5)
            {
                UpRate = 1;
            }
            int Enhance = rnd.Next(1, 101);
            if (Enhance <= UpRate)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            //평균값 구하는 함수
            int[] nums = { 100, 60, 98, 80, 90 };
            Console.WriteLine("=== 평균 값 ===");
            
            Console.WriteLine($"당신의 평균 값: {GetAverage(nums)}\n");
            


            //등급 판별 함수
            int avrScore = (int)GetAverage(nums);
            Console.WriteLine("=== 성적 ===");
            Console.Write("당신의 성적: ");
            Grade(avrScore);
            Console.WriteLine();



            //소수 판별 함수
            Console.WriteLine("=== 소수 판별 ===");
            Console.WriteLine("당신의 수를 입력하세요: ");
            int PrimeNum = int.Parse(Console.ReadLine());
            bool Prime = IsPrimeNum(PrimeNum);
            if (Prime)
            {
                Console.WriteLine($"{PrimeNum}은 소수입니다!");
            }
            else
            {
                Console.WriteLine($"{PrimeNum}은 소수가 아닙니다!");
            }
            Console.WriteLine();




            //경험치 시스템
            Console.WriteLine("=== 경험치 시스템 ===");
            int NowExp = 650;
            Console.WriteLine($"현재 경험치: {NowExp}/1000p ");
            LevelUp(NowExp, 400);
            Console.WriteLine();




            //아이템 강화 시스템
            Random rand = new Random();
            Console.WriteLine("=== 아이템 강화 시스템 ===");
            Console.WriteLine("아이템을 강화하시겠습니까? ");
            Console.ReadLine();
            int ItemLevel = 10;
            Console.WriteLine("현재 아이템 레벨: " +  ItemLevel);
            bool ItemLevelUp = ItemEnhance(ItemLevel);

            if (ItemLevelUp)
            {
                ItemLevel++;
                Console.WriteLine("아이템 강화 성공!");
                Console.WriteLine($"현재 아이템 레벨: {ItemLevel}");
            }
            else
            {
                Console.WriteLine("강화 실패.. 다시 도전하세요.");
            }
        }
    }
}
