using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_inheritance
{
    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }
    public class Warrior : Character
    {
        public override void Render()
        {
            Console.WriteLine("워리어");
        }
    }

    public class Mage: Warrior
    {
        public override void Render()
        {
            Console.WriteLine("메이지");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Warrior();
            //character.Render();     //출력: 캐릭터

            //Character character1 = new Warrior();   //부모 타입에 자식 메모리 참조하는 것: 업캐스팅
            //character1.Render();    //출력: 워리어

            //Warrior warrior = new Mage();           //자식 타입에 손자의 메모리를 넣었음.
            //warrior.Render();       //출력: 메이지

            if (character is Warrior)
            {
                Warrior warrior = (Warrior)character;
                warrior.Render();
            }
        }
    }
}
