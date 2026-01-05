using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Day2_d2_video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String PlayerName = "hahnroxx";
            int Level = 100;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            Console.WriteLine("┃        === STATUS ===        ┃");
            Thread.Sleep(1000);

            Console.WriteLine("┃       player: " + PlayerName + "       ┃");
            Console.WriteLine("┃             level: " + Level + "       ┃");
            Thread.Sleep(1000);

            Console.WriteLine("");


            Console.WriteLine("             로딩중....");
            Thread.Sleep(500);
            Console.Write("   진행률 : [");
            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.Write("■");
            Thread.Sleep(500);

            Console.WriteLine("] 100% \n");
            Thread.Sleep(500);

            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("┃      ■■■■게임 시작■■■■       ┃");
            

            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
