using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day10_abstractClaSS
{
    internal class Program
    {
        public abstract class Character
        {
            protected string Name;
            protected int Hp;
            protected int MaxHp;
            protected int Spd;

            public Character(string name, int health, int spd)
            {
                Name = name;
                MaxHp = health;
                Hp = MaxHp;
                Spd = spd;
            }

            public abstract void ShowInfo();    //구현 안되므로 반드시 자식이 구현
        }

        class Warrior : Character
        {
            private int attack;
            private int defense;

            public Warrior(string name) : base(name, 200, 5)
            {
                attack = 80;
                defense = 50;
            }
            public override void ShowInfo()
            {
                Console.WriteLine("========================");
                Console.WriteLine($"[전사]{Name}");
                Console.WriteLine($"HP: {Hp}/{MaxHp}");
                Console.WriteLine($"공격력: {attack}");
                Console.WriteLine($"방어력: {defense}");
                Console.WriteLine($"이동속도: {Spd}");
                Console.WriteLine("========================");
            }
        }
        class Wizard : Character
        {
            private int magicPower;
            private int mana;

            public Wizard(string name) : base(name, 120, 4)
            {
                magicPower = 150;
                mana = 100;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine($"[마법사] {Name}");
                Console.WriteLine($"HP: {Hp}/{MaxHp}");
                Console.WriteLine($"마력: {magicPower}");
                Console.WriteLine($"마나: {mana}");
                Console.WriteLine($"이동속도: {Spd}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            }
        }
        class Ranger : Character
        {
            private int rangedAttack;
            private int arrows;

            public Ranger(string name) : base(name, 150, 6)
            {
                rangedAttack = 100;
                arrows = 50;
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine($"[궁수] {Name}");
                Console.WriteLine($"HP: {Hp}/{MaxHp}");
                Console.WriteLine($"공격력: {rangedAttack}");
                Console.WriteLine($"화살: {arrows}");
                Console.WriteLine($"이동속도: {Spd}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            }
        }
        ////오류나는 이유: 추상 클래스 상속 받고 있는 것은 추상 메서드를 상속 받아서 꼭 구현해야 한다.
        //public class Mage : Character       
        //{
        //    //이 아랫줄처럼 구현해야 정상 작동한다.
        //    public override void Job()
        //    {
        //        Console.WriteLine("직업: 마법사");
        //    }
        //}
        static void Main(string[] args)
        {
            //Mage mage = new Mage();
            //mage.Job();
            Character[] units = new Character[3];
            units[0] = new Warrior("김한");
            units[1] = new Wizard("박마법");
            units[2] = new Ranger("이궁수");

            foreach (Character unit in units)
            {
                unit.ShowInfo();
            }
        }
    }
}
