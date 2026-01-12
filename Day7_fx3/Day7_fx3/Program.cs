using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_fx3
{
    internal class Program
    {
        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다. {playerName}님!");
        }

        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업: {job}");
            Console.WriteLine($"레벨: {level}");
        }

        //매개변수 3개 체력자 출력
        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.WriteLine("HP");
            int filledLength = (int)((double)current / max * barLength);

            for (int i = 0; i < barLength; i++)
            {
                if (i <= filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }
            Console.WriteLine($"[{current}/{max}]");
        }
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"    {target}에게 {damage} 데미지!");
        }



        static void Main(string[] args)
        {
            //실전예제
            //2단계 매개변수 활용 
            
            GreetPlayer("홍길동");
            Console.WriteLine();

            ShowPlayerInfo("전사", 50);
            Console.WriteLine();

            DrawHealthBar(75, 100, 20);
            DrawHealthBar(30, 100, 20);
            DrawHealthBar(100, 100, 20);
            Console.WriteLine();


            ShowDamage("플레이어", "고블린", 85);
            Console.WriteLine();
            ShowDamage("드래곤", "플레이어", 120);

            Console.WriteLine("당신은 죽었습니다...");

            Console.Write("부활! 다시 돌아온 것을 ");
            GreetPlayer("홍길동");
        }
    }
}
