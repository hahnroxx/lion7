using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day7_fx4
{
    internal class Program
    {
        static int GetNumber()  //함수 제작
        {
            return 442;
        }

        static string PlayerName(string name)
        {
            return name;
        }

        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지: 100");
        }
        static void Attack(string target, int damage)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine($"데미지: {damage}");
        }

        static void Attack(string skillName, string target, int damage)
        {
            Console.WriteLine($"✨ 스킬 발동: {skillName}");
            Console.WriteLine($"⚔️ {target}에게 {damage} 데미지!");
        }

        

        static string ConnectMessage(string name)
        {
            return name + " 님 접속하셨습니다.";
        }
        static void Main(string[] args)
        {
            //int num = GetNumber();
            //Console.WriteLine("숫자 반환: "+ num);

            string hahn = ConnectMessage("한");
            Console.WriteLine(hahn);

            Console.WriteLine();
            Attack();
            Console.WriteLine();
            Attack("Monster", 100);

            Console.WriteLine();
            Attack("fireball", "dragon", 150);
        }

        static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        {
            Console.WriteLine("Casting FireBall!");
            Console.WriteLine($"target: {target}");
            Console.WriteLine($"damage: {damage}");
            Console.WriteLine($"mana cost: {manaCost}");

        }

    }
}
