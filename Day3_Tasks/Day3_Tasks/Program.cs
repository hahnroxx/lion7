using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day3_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제 1. RPG 체력 계산기

            int MaxHealth = 100;
            int CurrentHP = 80;
            int Damage = 25;
            int Heal = 30;
            int PoisonDamage = 5;

            Console.WriteLine("=== 문제 1 답안 ===");
            Console.WriteLine($"\n초기 체력: {CurrentHP} / {MaxHealth}");
            CurrentHP -= Damage;
            Console.WriteLine($"데미지 -{Damage}: {CurrentHP} / {MaxHealth}");
            CurrentHP += Heal;
            Console.WriteLine($"회목 +{Heal}: {CurrentHP} / {MaxHealth}");
            CurrentHP -= PoisonDamage;
            Console.WriteLine($"독 데미지 -{PoisonDamage}: {CurrentHP} / {MaxHealth}");


            //문제 2. 경험치와 레벨 계산

            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;

            Console.WriteLine("\n=== 문제 2 답안 ===");
            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");

            Console.WriteLine("획득 경험치: " + expPerMonster * monstersKilled);
            Console.WriteLine($"레벨 업까지 필요 경험치: {expForLevelUp - expPerMonster * monstersKilled}");


            //문제 3. 아이템 분배 시스템

            int totalGold = 1234;
            int partuMembers = 5;

            Console.WriteLine("\n=== 문제 3 답안 ===");
            Console.WriteLine("총 골드: " + totalGold);
            Console.WriteLine("파티원: " + partuMembers);
            Console.WriteLine($"1인당 골드: {totalGold / partuMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partuMembers}");


            //문제 4. 던전 입장 가능 여부

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP = 60;
            int maxHP = 100;

            Console.WriteLine("\n=== 문제 4 답안 ===");
            Console.WriteLine("<<<<< 던전 입장 조건 >>>>>");

            Console.WriteLine($"레벨 조건({requiredLevel} 이상): {playerLevel >= requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건(50% 이상): {currentHP >= maxHP / 2}");
            Console.WriteLine($"입장 가능: {playerLevel >= requiredLevel && hasKey && currentHP >= maxHP / 2}");


            //문제 5. 상점 할인 계산기

            double originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            //할인율 계산: 가격 * 0.8
            //쿠폰 할인: 가격 - 500

            Console.WriteLine("\n=== 문제 5 답안 ===");
            Console.WriteLine($"원가: {originalPrice}G");
            if (isVIP) originalPrice = originalPrice * 0.8;
            Console.WriteLine($"VIP 할인(20%): {originalPrice}G");
            if (hasCoupon) originalPrice = originalPrice - 500;
            Console.WriteLine($"쿠폰 할인(-500G): {originalPrice}G");
            Console.WriteLine($"최종 가격: {originalPrice}G");


            



        }
    }
}
