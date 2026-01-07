using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_controls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ////아이템 구매 시스템
            //int PlayerGold = 500;
            //int ItemPrice = 250;
            //string ItemName = "데이스웬";

            //Console.WriteLine("=== 무기 상점 ===");
            //Console.WriteLine($"\n아이템: {ItemName}");
            //Console.WriteLine($"가격: {ItemPrice}G");
            //Console.WriteLine($"소지금: {PlayerGold}G");

            //Console.WriteLine("구매");

            //if (PlayerGold >= ItemPrice)
            //{
            //    Console.WriteLine("\n✅ 구매 성공");
            //    Console.WriteLine($"{ItemName}을 획득했습니다!");
            //    Console.WriteLine($"남은 골드: {PlayerGold}G");
            //}
            //else 
            //{
            //    int needGold = ItemPrice = PlayerGold;
            //    Console.WriteLine("소지금이 부족합니다.");
            //    Console.WriteLine($"필요한 골드: {needGold}G");

            //}

            //Console.WriteLine("\n=== 던전 입장 ===");
            //int PlayerLevel = 158;
            //int RequiredLevel = 200;

            //if (PlayerLevel >= RequiredLevel)
            //{
            //    Console.WriteLine("\n🚪 던전에 입장합니다.");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    Console.WriteLine("🚫 레벨이 부족합니다!");
            //    Console.WriteLine($"필요 레벨: {RequiredLevel}");
            //    Console.WriteLine($"현재 레벨: {PlayerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다: {RequiredLevel - PlayerLevel}");

            //}

            ////점수에 따른 등급 판정
            //int score = 0;
            //string rank;


            //Console.WriteLine("=== 게임 랭크 시스템 ===");
            //Console.Write("당신의 점수를 입력하세요: ");
            //score = int.Parse(Console.ReadLine());
            //Console.WriteLine($"\n점수 : {score}");

            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급: {rank} (레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급: {rank} (마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급: {rank} (다이아몬드)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급: {rank} (플래티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else 
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급: {rank} (골드)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 1000");
            //}

            //캐릭터 상태

            Console.WriteLine("\n=== 캐릭터 상태 ===");
            
            Console.Write("당신의 체력을 입력하세요: ");
            int Health = int.Parse(Console.ReadLine());

            if (Health >= 80)
            {
                Console.WriteLine("💚 상태: 매우 좋음");
            }
            else if (Health >= 60)
            {
                Console.WriteLine("🟢 상태: 좋음");
            }
            else if (Health >= 40)
            {
                Console.WriteLine("🟡 상태: 보통");
            }
            else if (Health >= 20)
            {
                Console.WriteLine("🟠 상태: 위험");
            }
            else 
            {
                Console.WriteLine("🔴 상태: 매우 위험!");
                Console.WriteLine("회복 물약을 사용하세요!");
            }



        }
    }
}
