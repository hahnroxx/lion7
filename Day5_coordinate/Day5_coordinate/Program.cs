using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day5_coordinate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int targetX = 50;
            const int targetY = 20;
            Console.OutputEncoding = Encoding.UTF8;
            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo;     //키 관련 정보

            Console.CursorVisible = false;  //커서 안 보이게 하기

            while (true) 
            {
                Console.Clear();    //화면 지우기

                Console.SetCursorPosition(targetX, targetY);
                Console.Write("쥰쥰");

                Console.SetCursorPosition(x, y); // 좌표

                Console.Write("한");     // 현재 위치 출력

                

                if (x == targetX && y == targetY)
                {
                    Console.Clear() ;
                    Console.WriteLine("사랑을 찾았다!!");
                    break;
                }

                keyInfo = Console.ReadKey(true);    // 키 입력 받기 (화면 출력 안하고)

                //방향키 입력에 따른 좌표 변경
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                            y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 1)
                            y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                            x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 1)
                            x++;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write("안아줘요!");
                        break;
                    case ConsoleKey.Escape:
                        break;

                }
                
            }
        }
    }
}
