using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_assign
{
    public class Animal
    {
        protected string Name;
        protected int Height;
        protected int Weight;
        protected int Age;

        protected Animal(string name, int height, int weight, int age)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Age = age;
        }

        public virtual void ShowAnimalInfo()
        {
            
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"키: {Height} cm");
            Console.WriteLine($"무게: {Weight} kg");
            Console.WriteLine($"나이: {Age}살");
        }
    }

    public class Basilisk : Animal
    {
        public Basilisk(string name, int height, int weight, int age) : base(name, height, weight, age)
        {
            

        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("🐍 바실리스크를 소개합니다!");
            base.ShowAnimalInfo();
            Console.WriteLine("⚠️ 시선을 마주치면 돌로 변합니다!");
        }
    }

    public class Dragon : Animal
    {
        public Dragon(string name, int height, int weight, int age) : base (name, height, weight, age) 
        {
        

        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("🐉 혼테일을 소개합니다!");
            base.ShowAnimalInfo ();
            Console.WriteLine("⚠️ 굉장히 사납습니다 주의하세요!");
        }
    }

    public class ThunderBird : Animal
    {
        public ThunderBird(string name, int height, int weight, int age) : base(name,height, weight, age) 
        {
           
        }

        public override void ShowAnimalInfo()
        {
            Console.WriteLine("🦅 천둥새를 소개합니다!");
            base.ShowAnimalInfo();
            Console.WriteLine("⚠️ 폭풍우가 치기 시작합니다!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 환상의 동물을 소개합니다! ===\n");
            Console.OutputEncoding = Encoding.UTF8;
            Animal animal1 = new Basilisk("바실리스크", 652, 900, 1100);
            animal1.ShowAnimalInfo();
            Console.WriteLine();
            Animal animal2 = new Dragon("혼테일", 1290, 2605, 326);
            animal2.ShowAnimalInfo();
            Console.WriteLine();
            Animal animal3 = new ThunderBird("천둥새", 381, 402, 72);
            animal3.ShowAnimalInfo();
        }
    }
}
