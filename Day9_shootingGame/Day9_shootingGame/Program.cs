using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day9_shootingGame
{
    //클래스끼리 통신
    class Player
    {
        private int att;
        private int hp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetAtt(int att)
        {
            this.att = att;
        }

        public int GetAtt()
        {
            return att;
        }

        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine("체력: " + hp);
            Console.WriteLine("공격력: " + att);
        }
    }
    class Monster
    {
        private int att;
        private int hp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetAtt(int att)
        {
            this.att = att;
        }

        public int GetAtt()
        {
            return att;
        }
        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine("체력: " + hp);
            Console.WriteLine("공격력: " + att);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //플레이어 객체
            Player player = new Player();
            player.SetAtt(10);
            player.SetHp(100);
            player.Render();
            //몬스터 객체
            Console.WriteLine();
            Monster monster = new Monster();
            monster.SetAtt(5);
            monster.SetHp(50);
            monster.Render();

            //플레이어 몬스터 전투(객체끼리 통신)
            monster.SetHp(monster.GetHp() - player.GetAtt());
            player.SetHp(player.GetHp() - monster.GetAtt());
        }
    }
}
