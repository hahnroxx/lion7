using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_property
{
    class Character
    {
        //private int Attack;

        ////get, set 함수.
        //public void SetAttack(int _Attack)
        //{
        //    Attack = _Attack;
        //}   // set: 외부에서 값을 변경하는 함수
        //public int GetAttack()
        //    { return Attack; }
        //// get: 외부에서 값을 가져오는 함수

        //private int att;
        

        //////프로퍼티
        ////public int Att
        ////{
        ////    get { return att; }

        ////    set
        ////    {
        ////        att = value;    //인자를 직접 선언하지 않아도 밸류로 가져올 수 있음
        ////    }
        ////}   //이렇게 만든 걸 GetAtt, SetAtt 이렇게 함수로 바로 사용할 수 있음

        //public int Att { get; set; }    //자동 프로퍼티

        ////읽기 전용
        //public int MaxHP {  get; private set; }


    }
    //====================================
    class Player
    {
        private string name;
        private int gold;

        public string Name { get { return name; } set { name = value; } }
        public int Gold { 
            get { return gold; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("골드가 부족합니다...");
                }
                else
                {
                    gold = value;
                }
            }
    }



    internal class Program
    {
            static void Main(string[] args)
            {
                ////Character c = new Character();
                ////c.SetAttack(10);

                ////Console.WriteLine("공격력: " + c.GetAttack()); 

                //Character Player = new Character();
                //Player.Att = 1;

                //Console.WriteLine("공격력: "+ Player.Att);

                Player player = new Player();
                player.Name = "김한";
                player.Gold = 1000;

                Console.WriteLine($"이름: {player.Name}");
                Console.WriteLine($"골드: {player.Gold}G");

            }
        }
    }
}
