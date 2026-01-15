using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_상속
{
    class Character
    {
        //접근 제어자 중에 protected도 쓸 수 있음. 상속이 되어있는 자식이 사용 가능하게 열어주는 식.
        protected string name;
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int attack;
        protected int defense;

        public Character(string characterName)
        {
            name = characterName;
            level = 1;
            maxHP = 100;
            hp = maxHP;
            attack = 30;
            defense = 20;

            Console.WriteLine($"캐릭터 {name} 생성!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
        }

        
    }

    //자식 클래스: 전사
    class Warrior: Character
    {
        private int rage;   //전사만의 고유 속성
        public Warrior(string name) : base(name)    //base로 부모 생성자 호출 때 매개변수 전달
        {

            //name = "dragonWarrior";       //base.name 과 같다.
            attack = 60;
            defense = 40;
            maxHP = 150;
            hp = maxHP;
            rage = 0;

            Console.WriteLine("직업: 워리어");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();    //부모의 ShowInfo 호출
            Console.WriteLine($"분노: {rage}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 캐릭터 생성 ===");
            
           
            Character character = new Warrior("hahnroxx");      //자식으로 new 할당하면 재정의 상태로 메서드 오버라이딩 되고 자식 함수 호출
            character.ShowInfo();       //재정의.
        }
    }
}
