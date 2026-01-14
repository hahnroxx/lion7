using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8_class2
{
    //캐릭터 클래스 정의
    class Character
    {
        //필드 : 클래스의 데이터
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        //생성자로 만들어서 쓸 때:
        public Character(string _name, int _level, int _Hp, int _Mp, int _MaxHp, int _MaxMp)
        {
            name = _name;
            level = _level;
            hp = _Hp;
            maxHP = _Mp;
            mp = _MaxHp;
            maxMP = _MaxMp;
        }

        // 아예 함수로 만들어서 쓸수도 있음:
        public void SetInfo(string _name, int _level, int _hp, int _maxHP, int _MaxMp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            mp = _MaxMp;
            maxHP = _maxHP;
            //뭐 이런 식으로 ㅇㅇ
        }



        //메서드 : 클래스의 기능
        public void ShowStats()
        {
            Console.WriteLine($"+++++++++++++++++");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"Hp: {hp} / {maxHP}");
            Console.WriteLine($"Mp: {mp} / {maxMP}");
            Console.WriteLine($"+++++++++++++++++");
        }

        public void TakeDamage(int Damage)
        {
            hp -= Damage;
            if ( hp < 0 ) hp = 0;
            Console.WriteLine($"⚔️ {name}이(가) {Damage} 데미지를 받았습니다.");
            Console.WriteLine($"남은 Hp: {hp}/{maxHP}");
            if(hp == 0)
            {
                Console.WriteLine($"💀 {name}이(가) 사망했습니다...");
            }
        }

        public void Heal(int amount)
        {
            hp += amount;
            if ( hp > maxHP) hp = maxHP;
            Console.WriteLine($"💚 {name}의 Hp가 {amount}만큼 회복되었습니다.");
            Console.WriteLine($"현재 Hp {hp}/{maxHP}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //객체 생성
            Character player = new Character("hahnroxx", 10, 100, 100, 50, 50);
            //필드(변수) 설정
            //player.name = "hahnroxx";
            //player.level = 10;
            //player.hp = 100;
            //player.maxHP = 100;
            //player.mp = 50;
            //player.maxMP = 50;
            //스탯 메서드 호출
            player.ShowStats();
            Console.WriteLine();
            //데미지 메서드 호출
            player.TakeDamage(50);
            Console.WriteLine();
            //힐 메서드 호출
            player.Heal(30);
            Console.WriteLine();
            player.TakeDamage(100);
            Console.WriteLine();

            //새로운 객체 생성
            Character player2 = new Character("홍길동", 20, 200, 200, 100, 150);
            //player2.name = "홍길동";
            //player2.level = 20;
            //player2.hp = 200;
            //player2.maxHP = 200;
            //player2.mp = 100;
            //player2.maxMP = 150;
            //player2.ShowStats();
        }
    }
}
