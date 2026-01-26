using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG_DungeonBob
{
    internal class Battle
    {
        private static readonly Random rand = new Random();

        //true : 승리(원물 루팅) , false : 도망 또는 패배
        public static bool StartBattle(GameState gameState)
        {
            //몬스터 스탯
            string monsterName = "몬스터";
            int monsterHp = 30;
            int monsterAtk = 6;

            bool guarding = false;

            while (gameState.PlayerHp > 0 && monsterHp > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("===== 전투에 돌입합니다 =====");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"현재 체력: {gameState.PlayerHp}/{gameState.PlayerMaxHp}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 방어");
                Console.WriteLine("3. 도망");
                Console.Write("당신의 행동을 선택하세요: ");

                int input = int.Parse(Console.ReadLine());

                //플레이어 턴
                if (input == 1)
                {
                    int damage = 10 + rand.Next(-2, 5);     //데미지가 바리에이션 주기(크리티컬 효과, 미스 효과)
                    if (damage < 1) damage = 1;

                    monsterHp -= damage;
                    Console.WriteLine($"\n🧙🏻‍ 당신이 {damage} 만큼의 피해를 입혔습니다!");
                    Console.WriteLine($"몬스터의 체력: {monsterHp}");
                    Console.ReadKey(true);
                }
                else
                {
                    int escape = rand.Next(1, 101);
                    if (escape <= 45)
                    {
                        Console.WriteLine("\n도망 성공!");
                        Console.ReadKey(true);
                        return false;
                    }
                    Console.WriteLine("\n도망 실패..");
                    Console.ReadKey(true);
                }

                //몬스터 사망 시 전투 종료
                if (monsterHp <= 0)
                    break;


                //이제 몬스터 턴
                int monsterDamage = monsterAtk;
                if (monsterDamage < 1) monsterDamage = 1;

                gameState.PlayerHp -= monsterDamage;

                Console.WriteLine($"\n몬스터의 공격으로 {monsterDamage}의 피해를 입었습니다!");
                Console.ReadKey(true);
            }

            //승리 시 보상

            Console.WriteLine("\n승리! 몬스터를 처치했습니다.");
            gameState.RawMonster += 1;
            Console.WriteLine($"현재 몬스터 원물 개수: {gameState.RawMonster}개 ");
            Console.ReadKey(true);

            return true;
        }
    }
}
