using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day8_RPG
{
    //캐릭터 클래스
    class Character
    {
        //private 필드
        private string name;
        private string job;
        private int level;
        private int hp;
        private int maxHp;
        private int mp;
        private int maxMp;
        private int attack;
        private int defense;
        private int exp;
        private int gold;

        //public 프라퍼티
        public string Name { get { return name; } }
        public string Job { get { return job; } }
        public int Level { get { return level; } }
        public int HP { get { return hp; } }
        public int MaxHp { get { return maxHp; } }
        public int MP { get { return mp; } }
        public int MaxMp { get { return maxMp; } }
        public int Attack { get { return attack; } }
        public int Defense { get { return defense; } }
        public int Gold { get { return gold; } }
        public int Exp { get { return exp; } }

        //생성자
        public Character(string characterName, string characterJob)
        {
            name = characterName;
            job= characterJob;
            level = 10;
            exp = 0;
            gold = 1000;

            //직업별 초기 스탯
            if (job == "Warrior")
            {
                maxHp = 200;
                maxMp = 50;
                attack = 80;
                defense = 70;
            }
            else if (job == "Magician")
            {
                maxHp = 100;
                maxMp = 100;
                attack = 100;
                defense = 30;
            }
            else if (job == "Archer")
            {
                maxHp = 150;
                maxMp = 80;
                attack = 90;
                defense = 50;
            }

            hp = maxHp;
            mp = maxMp;

            Console.WriteLine($"당신의 {name}({job}) 캐릭터가 생성되었습니다.");
        }

        //스탯 표시
        public void ShowStats()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━STATUS━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃           {name} | {job}             ┃");
            Console.WriteLine($"┃              Level | {level}                  ┃");
            Console.WriteLine($"┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine($"┃  HP: {hp}/{maxHp,-30}  ┃");
            Console.WriteLine($"┃  MP: {mp}/{maxMp,-30}   ┃");
            Console.WriteLine($"┃  공격력: {attack,-31} ┃");
            Console.WriteLine($"┃  방어력: {defense,-31} ┃");
            Console.WriteLine($"┃  경험치: {exp}/100{"",-27}┃");
            Console.WriteLine($"┃  골드: {gold,-33} ┃");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        //공격
        public int AttackTarget(Character target)
        {
            Random r = new Random();
            bool isCritical = r.Next(0, 1) <= 20;

            int damage = this.attack = target.defense / 2;
            if (damage < 0) damage = 0;

            //데미지 편차
            int variance = r.Next(-10, 11);
            damage = damage * (100 + variance) / 100;

            if (isCritical)
            {
                damage = (int)(damage * 1.5);
                Console.WriteLine($"⚔️ {this.name}의 크리티컬 공격! ⚔️");
            }
            else
            {
                Console.WriteLine($"⚔️ {this.name}의 공격!");
            }
            target.TakeDamage( damage );    
                return damage;
        }

        //데미지 받기
        private void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($" {name}에게 {damage}를 받았습니다.");
            Console.WriteLine($"남은 Hp: {hp}/{maxHp}");

            if (hp == 0)
            {
                Console.WriteLine($"💀 {name}이 쓰러졌습니다..");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character("hahnroxx", "Warrior");
            player.ShowStats();
        }
    }
}
