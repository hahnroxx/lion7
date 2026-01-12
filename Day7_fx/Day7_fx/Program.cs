using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_fx
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //////////함수
            //Hello();
            //Hello();    //재사용
            GameStart();
            PrintLine();
            Hello();
        }
        static void Hello()
        {
            Console.WriteLine("안녕하세요. 용사님.");
            Console.WriteLine("이세계에 오신 것을 환영합니다.");
        }

        static void GameStart()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║ ⚔  RPG 게임 시작  ⚔  ║");
            Console.WriteLine("╚══════════════════════╝");
            
        }
        static void PrintLine()
        {
            Console.WriteLine("------------------------------------");
        }
        
    }
}
