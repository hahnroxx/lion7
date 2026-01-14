using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day8_class
{
    class 클래스이름
    {
        //필드 - 변수(데이터)
        //메서드(함수)
    }

    class Character
    {
        //클래스 내부에서 변수 정의
        public string Name;
        public int Level;
        public int Hp;
        public int MaxHp;
        public int Mp;
        public int MaxMp;

        //기본 생성자 : 초기화를 바로 할 때 사용함 
        public Character()
        {
            Name = "한";
            Level = 1;
            Hp = 100;
            MaxHp = 200;
            Mp = 50;
            MaxMp = 100;
        }
        //클래스에서 함수를 모아서 사용할 수 있다.
        //main의 크기를 줄이면서 바깥에서 불러와서 코딩하는 것을 객체지향성이라 부름.
        
        //인자 있는 생성자
        public Character(string _name, int _level, int _Hp, int _Mp, int _MaxHp, int _MaxMp)
        {
            Name = _name;
            Level = _level;
            Hp = _Hp;
            MaxHp = _Mp;
            Mp = _MaxHp;
            MaxMp = _MaxMp;
        }

        //이번엔 함수를 모아서 사용하는 애를 만들자
        public void ShowStats()
        {
            Console.WriteLine("==== 캐릭터 생성 ====\n");
            Console.WriteLine("이름: " + Name);
            Console.WriteLine("레벨: " + Level);
            Console.WriteLine($"Hp: {Hp}/{MaxHp}");
            Console.WriteLine($"Mp: {Mp}/{MaxMp}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character Player1 = new Character();    
            //이렇게 했을 경우에 생성자가 여기서 호출됨.

            Console.WriteLine("==== 캐릭터 생성 ====\n");
            Console.WriteLine("이름: " +  Player1.Name);
            Console.WriteLine("레벨: " + Player1.Level);
            Console.WriteLine($"Hp: {Player1.Hp}/{Player1.MaxHp}");
            Console.WriteLine($"Mp: {Player1.Mp}/{Player1.MaxMp}\n");
            Thread.Sleep(1000);

            Character Player2 = new Character();

            Player2.Name = "홍승아";
            Player2.Level = 1;
            Player2.Hp = 100;
            Player2.MaxHp = 200;
            Player2.Mp = 50;
            Player2.MaxMp = 100;

            Console.WriteLine("==== 캐릭터 생성 ====\n");
            Console.WriteLine("이름: " + Player2.Name);
            Console.WriteLine($"레벨: { Player2.Level * 100}");
            Console.WriteLine($"Hp: {Player2.Hp}/{Player2.MaxHp}");
            Console.WriteLine($"Mp: {Player2.Mp}/{Player2.MaxMp}\n");
            Thread.Sleep(1000);

            Character Player3 = new Character("박준호",1,50,100,50,100);

            Console.WriteLine("==== 캐릭터 생성 ====\n");
            Console.WriteLine("이름: " + Player3.Name);
            Console.WriteLine($"레벨: {Player3.Level * 5}");
            Console.WriteLine($"Hp: {Player3.Hp}/{Player3.MaxHp}");
            Console.WriteLine($"Mp: {Player3.Mp}/{Player3.MaxMp}");
            Thread.Sleep(1000);

            Console.WriteLine();
            Character Player4 = new Character();
            Player4.ShowStats();

        }
    }
}
