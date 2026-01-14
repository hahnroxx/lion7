using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_static
{
    class Character
    {
        public static int TotalCount = 0;

        public string name;

        public void AddCount()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            c1.name = "워리어";
            c2.name = "매지션";

            Character.TotalCount = 1;

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            Console.WriteLine("카운트 : " +  Character.TotalCount);
        }
    }
}
