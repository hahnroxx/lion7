using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////가변배열
            //string[][] raid = new string[3][];
            //raid[0] = new string[] { "전사", "사제", "마법사", "도적", "궁수" };
            //raid[1] = new string[] { "전사", "마법사", "도적", "드루이드" };
            //raid[2] = new string[] { "마법사", "주술사", "기계공" };

            //Console.WriteLine("=== 파티 구성 ===");
            //for (int i = 0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"\n파티 {i + 1} ({raid[i].Length})명: ");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.Write($" - {raid[i][j]}");
            //    }
            //}

            ////동적배열
            //List<string> inventory = new List<string>();
            //Console.WriteLine();
            //Console.WriteLine("\n=== 도적 인벤토리 시스템 ===\n");

            ////아이템 추가 (Add)
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가");

            ////현재 인벤토리
            //Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            //inventory[0] = "초록포션";

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Dictionary<string,int> stats = new Dictionary<string,int>();

            //stats.Add("HP", 150);
            //stats.Add("MP", 100);
            //stats.Add("Atk", 1500);
            //stats.Add("Dfs", 90);
            //stats.Add("Crtcl", 60);

            //Console.WriteLine("=== Character Status ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}
            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}

            Dictionary<string, int> items = new Dictionary<string, int>();

            items.Add("HP Potion", 50);
            items.Add("MP Potion", 40);
            items.Add("Sword", 500);
            items.Add("LeatherArmor", 300);
            items.Add("MagicalRing", 1000);

            Console.WriteLine("==== Shoping List ====");

            int playerGold = 600;
            string foundItem = null;

            foreach (KeyValuePair<string, int> item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}G");
            }

            Console.Write("\nSelect item to buy: ");
            string input = Console.ReadLine();

            if (items.ContainsKey(input))
            {
                Console.WriteLine($"\nYou bought a {input}'!");
                playerGold -= items[input];
                Console.WriteLine($"Left Gold: {playerGold}G");
            }
            else
            {
                Console.WriteLine($"{input}골드 아이템 없음");
            }
        }
    }
}
