using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_class3
{
    class Monster
    {
        public string Name;
        public int Level;
        public int Hp;
        public int Attack;
        public int Defense;
        public int ExpReward;

        //기본 생성자
        public Monster()
        {
            Name = "슬라임";
            Level = 1;
            Hp = 50;
            Attack = 10;
            Defense = 5;
            ExpReward = 10;
        }

        //매개변수가 있는 생성자
        public Monster(string MonsterName, int MonsterLevel)
        {
            Name = MonsterName;
            Level = MonsterLevel;
            Hp = 50 * Level;
            Attack = 10 * Level;
            Defense = 5 * Level;
            ExpReward = 10 * Level;
        }

        //정보 출력
        public void ShowStats()
        {
            Console.WriteLine($"👾 {Name} (Lv.{Level})");
            Console.WriteLine($"\tHp: {Hp}");
            Console.WriteLine($"\tATK: {Attack}");
            Console.WriteLine($"\tDFS: {Defense}");
            Console.WriteLine($"\tEXP: {ExpReward}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //기본 생성자 사용해서 객체 생성
            Monster Slime = new Monster();
            //스탯 출력
            Slime.ShowStats();

            Console.WriteLine(); 
            Monster Goblin = new Monster("Goblin", 5);
            Goblin.ShowStats();

            Console.WriteLine();
            //배열 사용해서 만들기
            Console.WriteLine("==== 필드 몬스터 ====\n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("Barghest", 9);
            monsters[1] = new Monster("Ogre", 20);
            monsters[2] = new Monster("Necker", 6);

            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i].ShowStats();
                Console.WriteLine();
            }
        }
    }
}
