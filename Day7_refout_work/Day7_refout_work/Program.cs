using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_refout_work
{
    internal class Program
    {
        static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            ////swap의 예시.
            //int x = 10;
            //int y = 20;
            //int score;

            //score = x;  //score에 x값인 10을 넣어주고
            //x = y;      //x에 y값인 20을 넣어주고
            //y=score;    //이번엔 y에 score의 값인 x(=10)를 넣어줌

            //Console.WriteLine("x:" + x + " y:" + y);
            ////-----------> 이걸 함수로 바꿀 것이다.
            ///
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);
            Console.WriteLine("x: "+ x + " y: " + y);
        }
    }
}
