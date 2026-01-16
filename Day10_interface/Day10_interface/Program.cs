using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_interface
{
    interface IAttackable
    {
        void Attack(string target);

        int GetAttackPower();
    }

    interface IDefendable
    {
        void Defend(string target);
        int DefendStrength();
    }
    
    class Knight : IAttackable, IDefendable
    {
        public string name;
        public int attackPower;
        public int defendStrength;

        public Knight()
        {
            name = "검사";
            attackPower = 10;
            defendStrength = 20;
        }
        public void Attack(string target)
        {
            Console.WriteLine($"{target}을 검으로 공격!");
        }

        public void Defend(string target)
        {
            Console.WriteLine($"{target}의 공격을 방패로 방어!");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }
        public int DefendStrength()
        {
            return defendStrength;
        }
    }

    class Mage : IAttackable, IDefendable //알트 + 엔터
    {
        public string name;
        public int attackPower;
        public int defendStrength;

        public Mage()
        {
            name = "마법사";
            attackPower = 20;
            defendStrength = 15;
        }
        public void Attack(string target)
        {
            Console.WriteLine($"{target}을 마법으로 공격!");

        }

        public void Defend(string target)
        {
            Console.WriteLine($"{target}의 공격을 마법 방어!");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int DefendStrength()
        {
            return defendStrength;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Knight knight = new Knight();
            //knight.Attack("오크");
            //knight.Defend("오크");

            //Console.WriteLine();
            //Mage mage = new Mage();
            //mage.Attack("고블린");
            //mage.Defend("고블린");

            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = new Knight();
            attacker[1] = new Mage();

            IDefendable[] defender = new IDefendable[2];
            defender[0] = new Knight();
            defender[1] = new Mage();

            foreach (IAttackable att in attacker)
            {
                att.Attack("고블린");
            }

        }
    }
}
