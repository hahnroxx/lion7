using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day4_if_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int score = 85;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else
            //{
            //    Console.WriteLine("90점 미만");
            //}

            //int number = 10;
            //if (number > 15)
            //{
            //    Console.WriteLine("15보다 큽니다");
            //}
            //else
            //{
            //    Console.WriteLine("15보다 작거나 같습니다");
            //}

            //int score = 75;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else if (score >= 50)
            //{
            //    Console.WriteLine("D 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}



            //int a = 10;

            //if (a == 10)
            //    Console.WriteLine("A가 " + a + "입니다.");


            //else
            //    Console.WriteLine("여긴 10이 아닌경우야");


            //Console.WriteLine("if else 끝나고나서 실행되는곳이야");

            //int a = 78;

            //if (a >= 90)
            //{
            //    Console.WriteLine("A등급");
            //}
            //else if (a > 80 && a <= 89)
            //{
            //    Console.WriteLine("B등급");
            //}
            //else if (a > 70 && a <= 79)
            //{
            //    Console.WriteLine("C등급");
            //}
            //else
            //{
            //    Console.WriteLine("D등급");
            //}

            //int a = 78;

            //if (a >= 80)
            //{
            //    Console.WriteLine("통과");
            //}
            //if (a >= 70)
            //{
            //    Console.WriteLine("2통과");
            //}

            //예제

            int Health = 30;
            int MaxHealth = 100;

            Console.WriteLine("*** 실행 결과 ***");
            Console.WriteLine($"\n현재 체력: {Health} / {MaxHealth}");
            if (Health <= MaxHealth * 0.3)
            {
                Console.WriteLine($"경고: 체력이 위험합니다!");
                Console.WriteLine("회복 아이템을 사용하세요!");
            }
            if (Health <= MaxHealth * 0.5)
            {
                Console.WriteLine($"💊체력이 50% 이하입니다.");
            }
            if (Health <= 0)
            {
                Console.WriteLine("You Died");
                Console.WriteLine("부활 지점에서 다시 시작합니다.");
            }

            //게임 로직 예제
            int enemyDistance = 3;
            int attackRange = 5;

            if (attackRange >= enemyDistance)
            {
                Console.WriteLine("\n적이 사거리 안에 있습니다!");
                Console.WriteLine("공격 가능!");
            }
            else if (attackRange < enemyDistance)
                    { 
                    Console.WriteLine("\n적이 사거리 밖에 있습니다.");
                    Console.WriteLine("공격이 불가합니다.");
                

            }



        }
    }
}
