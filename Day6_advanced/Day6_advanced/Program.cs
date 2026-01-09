using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6_advanced
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            string[] player = new string[]
            {
                "*->" ,
                "{>>>",
                "*->"
                };

            int playerX = 0;
            int playerY = 12;

            const int MAX = 20;              // 화면에 동시에 존재 가능한 미사일 개수
            int[] mx1 = new int[MAX];
            int[] my1 = new int[MAX];
            int[] mx2 = new int[MAX];
            int[] my2 = new int[MAX];
            bool[] active = new bool[MAX];   // 이 슬롯 미사일이 살아있는가?

            // 시작 상태: 전부 비활성
            for (int n = 0; n < MAX; n++)
                active[n] = false;

            char misile = '-';
            int misileX = 0;
            int misileY = 0;

            char misile2 = '-';
            int misilei = 0;
            int misilej = 0;
            bool isShooting = false;

            ConsoleKeyInfo keyinfo;

            Console.CursorVisible = false;

            //sleep() //1000이면 1초동안 프로그램 멈춤
            //지연방법 시간을 계산해서 1초 루프 만들 것.
            int dwTime = Environment.TickCount;     // 1000분 1초가 흐릅니다.
            while (true)
            {
                if (dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키 영역
                    int pressKey;   //정수형 변수 선언 키값 받기



                    if (Console.KeyAvailable)    //키가 눌렸을 때 true
                    {
                        pressKey = _getch();
                        if (pressKey == 224)
                            pressKey = _getch();


                        switch (pressKey)
                        {
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: // 스페이스바: 연속 발사
                                {
                                    // 빈 슬롯 하나 찾기
                                    for (int n = 0; n < MAX; n++)
                                    {
                                        if (!active[n])
                                        {
                                            active[n] = true;

                                            // 비행기 앞부분에서 발사(오프셋 +3)
                                            mx1[n] = playerX + 3;
                                            my1[n] = playerY;       // 윗줄

                                            mx2[n] = playerX + 3;
                                            my2[n] = playerY + 2;   // 아랫줄

                                            break; // 한 번 누르면 한 슬롯만 발사(원하면 여러 슬롯 발사도 가능)
                                        }
                                    }
                                }
                                break;

                        }
                    }
                    if (isShooting)
                    {
                        misileX++;
                        misilei++;

                        if (misileX >= Console.BufferWidth - 1 || misilei >= Console.BufferWidth - 1)
                        {
                            isShooting = false;
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.Write(player[i]);
                       
                    }

                    // 미사일 그리기
                    for (int n = 0; n < MAX; n++)
                    {
                        if (active[n])
                        {
                            mx1[n]++;
                            mx2[n]++;

                            if (mx1[n] >= Console.BufferWidth - 2 || mx2[n] >= Console.BufferWidth - 2)
                            {
                                active[n] = false; // 화면 밖으로 나가면 비활성화
                            }
                        }
                    }
                    for (int n = 0; n < MAX; n++)
                    {
                        if (active[n])
                        {
                            // 윗줄 미사일
                            if (my1[n] >= 0 && my1[n] < Console.BufferHeight)
                            {
                                Console.SetCursorPosition(mx1[n], my1[n]);
                                Console.Write("-+@");
                            }

                            // 아랫줄 미사일
                            if (my2[n] >= 0 && my2[n] < Console.BufferHeight)
                            {
                                Console.SetCursorPosition(mx2[n], my2[n]);
                                Console.Write("-+@");
                            }
                        }
                    }
                }
            }

        }
    }
}
