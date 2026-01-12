using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_ref
{
    internal class Program
    {


        static void Attack(int a, int d, out int attack, out int defense)
        {
            attack = a;
            defense = d;
            attack++;
            defense++;
        }



        static void Main(string[] args)
        {
            int attack;
            int defense;


            Attack(10, 20, out attack, out defense);

            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"공격력 : {defense}");




        }
    }
}
