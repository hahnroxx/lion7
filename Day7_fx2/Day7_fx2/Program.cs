using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_fx2
{
    internal class Program
    {
        //int 넘겨보기
        static void Attack(int att, int def)
        {
            Console.WriteLine("당신의 공격력은: " + att);
            Console.WriteLine("당신의 방어력은: " + def);
        }
        
        static void Name(string name)
        {
            Console.WriteLine("플레이어 이름을 입력하세요: ");
            string nameDefault = Console.ReadLine();
            Console.WriteLine($"당신의 이름은 {nameDefault}입니다");
        }
        static void DexLux(int dex, int lux)
        {
            Console.WriteLine("당신의 민첩은: " + dex);
            Console.WriteLine("당신의 운은: " + lux);
        }
        //함수 만들기
        //플레이어 이름
        //공격력
        //방어력
        //민첩
        //운

        static void Main(string[] args)
        {
            Name("Hahn");
            Attack(100, 29);
            DexLux(50, 18);
        }

    }
}
