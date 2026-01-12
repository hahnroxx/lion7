using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day7_fx5
{
    internal class Program
    {
        static void itemUse(string ItemName, int ahealth = 50)
        {
            Console.WriteLine($"{ItemName} 사용!");
            Console.WriteLine($"회복량: {ahealth} Hp");
            

        }

        static void summon(string monster, int level, int monsterNum)
        {
            Console.WriteLine($"{monster} 소환!");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {monsterNum}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("=== 아이템 사용 ===");
            Console.WriteLine();
            itemUse("💊 회복 포션");
            Console.WriteLine();
            itemUse("💊 고급 회복 포션", 100);

            Console.WriteLine();
            Console.WriteLine("=== 소환 마법 ===");
            summon("✨슬라임", 1, 1);
            Console.WriteLine();
            summon("✨고블린", 5, 1);
            Console.WriteLine();
            summon("✨드래곤", 50, 3);
        }
    }
}
