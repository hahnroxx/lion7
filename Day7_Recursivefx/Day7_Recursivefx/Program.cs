using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Recursivefx
{
    internal class Program
    {
        //static void HelloWorld()
        //{
        //    Console.WriteLine("안녕하세요, 세상!");
        //    HelloWorld();   //이렇게만 하면 무한반복. 메모리 오버돼서 터짐.
        //}
        static int SumToN(int n)
        {
            if(n<=0)
            {
                return 0;
            }
            return n + SumToN(n - 1);   //n + (n-1까지의 합)
        }
        static void Main(string[] args)
        {
            int sum = SumToN(10);

            Console.WriteLine("1+2+.......+10 = " + sum);
        }
    }
}
