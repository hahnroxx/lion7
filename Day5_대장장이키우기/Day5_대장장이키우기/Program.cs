using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            

            string startText = "⚔️ Press any key to start ⚔️ ";
            int textX = 13;
            int textY = Console.WindowHeight - 3;

            Random rand = new Random();
                Thread.Sleep(1000);
            
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("┃                    Dungeon BOB                     ┃");
                Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
                Console.WriteLine("┃                     Loading....                    ┃");
                Thread.Sleep(500);
                Console.Write("┃                [");
                Console.Write("■");
                Thread.Sleep(500);

                Console.Write("■");
                Thread.Sleep(400);

                Console.Write("■");
                Thread.Sleep(300);

                Console.Write("■");
                Thread.Sleep(200);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("■");
                Thread.Sleep(100);

                Console.Write("]");
                Thread.Sleep(500);
                Console.WriteLine("   100%                 ┃");
                Thread.Sleep(500);

                Console.WriteLine("┃                                                    ┃");
            Console.WriteLine("┃⢇⠣⡃⡣⡑⡑⡑⡑⠅⠕⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠅⠕⠅⠕⢅⠣⡑⡑⢅┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢆⠕⡌⡢⠪⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⡨⡨⠜⠘⠊⠚⠬⡨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠢⡑⠌⢌⡂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢅⢃⠢⠪⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⠨⡨⠜⢈⠉⠈⠀⠀⠄⠂⠀⠄⠈⠃⠉⠊⠪⢌⠌⠌⠌⠌⠌⠌⠌⠌⠌⠌⢌⠢⠨⡈⠢⡑┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠢⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⠡⢱⠁⠀⡀⠀⠢⢅⠢⠠⡀⡂⢄⠢⡨⠠⠐⠀⠈⢎⠌⠌⠌⠌⠌⠌⠌⠌⢌⠢⡑⢌⠢⡈⠢┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠅⠅⠅⠅⠅⠅⠅⠅⠅⢅⡅⠅⠅⠅⠅⠅⢅⢑⢸⠀⡐⢄⢪⡨⡎⡳⡓⢴⢘⢲⢏⡪⠠⡀⠢⡑⡸⢌⠌⠌⠌⠌⠌⠌⠌⠢⠡⡑⠢⡑⢌⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠌⠌⠌⠌⠌⠌⠌⠌⢌⠎⡪⡌⠌⠌⠌⢌⢂⠂⡇⠣⢬⠦⡇⢪⠂⢸⠀⢸⠀⡱⠑⡝⠺⢬⡬⡚⢌⢊⠎⠌⠌⠌⠌⠌⠌⠌⠢⡈⠢⢌⢂⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠌⠌⠌⠌⠌⠌⠌⠌⡜⠀⡪⡸⡨⠨⡈⡂⡂⢅⠱⢌⣢⡣⡇⢰⠁⢸⠀⡕⠀⡇⢠⠃⡇⡇⡷⡱⡑⡜⠌⠌⠌⠌⠌⠌⠌⢌⢖⢂⠑⢌⢂⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠨⠨⠨⠨⠨⠨⡈⡂⡇⠀⡇⡢⡣⢁⢂⢂⢂⠢⢈⢂⠑⢵⢅⠜⢔⠚⠂⠓⠂⠧⢜⡸⡨⢲⠽⠜⡊⠌⠌⠌⠌⠌⢌⢜⢜⠵⡑⠠⡑⡐⡐⡐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠅⠅⠅⠅⢅⢑⠐⠄⡇⠀⡇⡊⡎⡐⡐⡐⡐⠨⡐⠄⠅⢎⠄⠀⠀⠠⠄⠀⡀⢀⢀⠪⡙⡎⠌⡂⠌⠌⠌⠌⠌⡘⣠⠾⡑⢕⠡⡁⡂⡂⡂⡂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠅⠅⢅⢑⠐⠄⠅⠅⡇⠀⡇⡪⡆⡂⡂⡊⠈⡢⡂⠅⠅⣕⡴⡶⠷⠟⠯⠷⢶⢶⣤⣑⠌⡎⡐⠨⠨⠨⠨⡨⣐⡼⢋⠒⠅⡂⡂⡂⡂⡂⡂⡂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢅⢑⠐⠄⠅⠅⠅⠅⡇⠀⡇⡢⡃⡂⡂⠢⡓⣆⠢⠡⢁⣺⢍⣶⣖⠀⢴⣷⣶⡑⣽⢽⢷⢁⠢⡥⡡⡡⢃⢴⢓⡱⢐⢈⢂⢂⢂⢂⢂⢂⢂⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢂⠢⠡⠡⠡⠡⠡⡁⡇⠀⡇⡪⡆⡂⡂⠅⢌⠘⡧⡁⣂⢾⠸⢿⢇⣶⠙⢿⠿⠃⢾⣻⣻⠲⡠⠑⢎⡲⣝⢕⠔⠨⡐⡐⡐⡐⡐⡐⢐⢐⢐⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠄⠅⠅⠅⠅⠅⠅⡂⡇⠀⡇⡢⡆⡂⡂⠅⡂⡂⠌⢗⣇⢻⣴⡂⡄⡌⡄⣄⢲⡴⠝⢋⢔⢝⢕⡥⢧⡛⢜⢌⠌⡐⡐⡐⡐⢐⢐⢌⢐⢐⢐⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠨⠨⠨⠨⠨⡈⡂⡂⡇⠀⡇⡢⡃⡂⡂⠅⡂⡂⢅⡇⢎⠢⣈⠉⠓⠓⡃⡉⠅⠄⠊⡌⢆⢕⡵⡻⡫⡣⡂⠕⠵⢐⢐⢐⢐⠰⡐⡐⡐⡐⡐⡐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠡⠡⠡⠡⢑⢐⠐⠄⡇⠀⡇⡪⡂⡂⡂⠅⣢⢊⢂⢳⡈⠱⢄⡉⠒⠑⠐⠄⠒⠊⡨⣠⣳⢫⠡⢠⠬⢞⢞⡌⠌⡐⡐⡐⢔⢑⢐⢐⢐⢐⢐⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠨⠨⠨⠨⢐⢐⢈⠂⡇⠀⡇⡪⡂⡂⡂⠅⡎⡓⡵⡍⡹⡶⣄⣌⢈⠂⡒⣂⡪⡬⢶⡗⡅⡕⢽⡱⣡⠥⢷⠾⡐⡒⡰⡍⡒⢔⡐⡐⡐⡐⡐⡐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠡⠡⠡⢑⢐⢐⠠⢁⡇⠀⡇⡪⡂⡂⡂⣕⢍⠳⣽⣪⣪⠞⠐⠌⢕⢏⢻⠈⠂⠈⢸⢱⢧⢝⢜⣼⡱⢘⢱⢴⢺⢹⢅⢸⢝⢶⢬⡒⣔⢐⢐⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠌⠌⢌⢂⢂⠢⢈⠂⡇⠀⡇⡪⡂⡂⢲⣡⢩⢳⢾⡏⠂⠀⠐⠀⠀⡃⢹⢰⡠⣀⢸⠠⠩⠻⡿⡗⣑⡵⣣⠑⡇⡗⡕⢘⢮⢳⠝⣱⡅⢇⢂⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠌⢌⢂⢂⠢⢈⠂⠅⡇⠃⡇⡪⡂⢢⡮⣮⢷⡻⣯⠇⡈⢰⡀⠂⠀⡂⠈⠅⢙⠈⠩⠠⡁⡣⡹⡑⡼⡪⡪⡳⡌⡪⠧⠸⣕⢃⡵⣳⢝⡎⡆⡂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⡑⡐⡐⡐⢌⠂⠅⠅⡇⠠⡳⡨⡪⠬⠻⢽⢵⢯⡿⡷⢦⢢⣳⣐⡅⠧⢱⣰⣱⢬⣌⣆⡮⡮⡎⢸⠣⠫⠎⠧⡏⡌⠁⢙⢔⣻⣪⣗⣝⣗⢸⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢐⢐⢐⠐⠄⠅⠅⠅⡇⢸⢸⡐⡝⡚⡪⣆⢝⣿⢏⢯⠧⠷⠵⡳⡭⣫⡥⣗⣎⡧⣳⢣⠯⡯⡇⣫⢔⡤⣢⢤⡇⡇⡕⣼⣳⢳⡴⡴⡴⣜⢺⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⢐⠐⠄⠅⡥⣡⠥⡥⠧⠽⠼⠬⠧⠷⢜⡬⣳⢍⢸⡜⠀⢁⠡⢹⣟⡿⣏⠂⠊⡞⣜⠀⠁⡭⣧⢘⢵⢱⢕⢵⠝⣪⣞⢳⣝⢝⣞⢽⢝⡎⡜⡐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠂⠅⠅⢅⢙⠪⠩⠩⣝⣛⣟⣻⡻⣟⡯⠯⢚⢀⢧⠃⢀⠀⢈⣺⢽⣹⣕⠀⠀⡯⡳⠈⠀⣪⡾⣆⠝⣜⠎⢡⢜⢮⡪⢸⢮⣳⡘⢵⡻⡰⢁⠢┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠡⠡⢑⢐⢐⠨⠨⡀⠫⣮⢾⣺⢛⢐⠨⠨⢐⢰⢕⠀⣰⡂⠀⣾⢯⢷⣗⠀⠀⡑⠑⣠⠀⢺⣟⣯⣧⡱⡪⣳⡹⣜⠎⢼⡳⣵⡻⡪⡪⠪⢐⠨┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠨⠨⢐⢐⢐⢈⠢⠨⠨⢸⣻⢅⢂⠂⠌⠌⡐⠬⢗⣴⣿⣢⡂⣿⢝⣗⣯⢀⡢⣿⡄⣾⣷⢸⡯⡷⡗⡘⠪⢆⡝⡚⣕⢝⢚⢕⢜⠊⠌⢌⠐⢌┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠨⠨⡐⡐⡐⡐⠨⠨⠨⢰⣻⡂⠢⠨⠨⢐⠨⢈⢢⡃⡸⡸⣻⣷⡟⡓⡛⢜⠛⢝⢙⣾⡏⣃⢂⡣⡇⡂⡑⢄⠕⢍⢊⠃⡍⡪⡂⠌⢌⠐⢌⢐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⡈⡂⡂⡂⡂⠌⠌⠌⠌⡇⡦⣝⠌⠌⢌⠐⠌⡐⠄⢳⣕⣝⡮⣷⢋⠂⠌⠄⠅⡂⡂⢻⡻⢼⣸⢼⢑⢐⢐⠨⢊⢂⠂⠅⡓⠜⠄⡑⡐⠨⡐⡐┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⡂⡂⡂⡂⡂⠅⠅⠅⠅⢍⠪⠡⠡⡁⠢⢈⠂⠌⠌⠄⡧⡱⢵⢵⢐⠨⠨⠨⢐⢐⢐⠠⡯⡪⡪⣺⢐⢐⢐⠨⢐⢐⢈⠢⠨⢈⢂⠂⢌⢂⢂⢂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⡂⡂⡂⠢⠨⠨⠨⠨⢈⠂⠅⠅⠅⡂⡑⡄⠅⠅⠅⣅⡧⢮⣪⡇⡂⠌⠌⠌⡐⡐⡐⠠⢱⣕⡵⣵⡐⡐⡐⠨⡐⡐⡐⠨⡨⠐⢄⢑⢐⢐⠐⠄┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠀⡈⠀⠂⠀⠄⠂⠁⡀⠂⢀⠁⡀⡂⡃⠢⢡⣕⣍⣖⣌⣳⠵⡇⠂⠁⢈⠀⠠⠈⡢⡑⡜⡮⣎⣢⣎⣲⣌⢀⠀⠂⡀⠄⠠⠀⠂⢀⠐⠈⠀⠂┃");
            Thread.Sleep(50);
            Console.WriteLine("┃⠁⡀⠄⠀⠄⠂⠐⠀⡈⠀⠂⠀⠄⠂⠁⡀⠂⢀⠁⠐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠠⠀⠂⢀⠐⠈⠀⠄┃");
            Thread.Sleep(50);
            Console.WriteLine("┃                ☆ ★ ☆ ★ START★ ☆ ★ ☆                ┃");


                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            
            while (!Console.KeyAvailable)
            {
                // 보이기
                Console.SetCursorPosition(textX, textY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(startText);

                Thread.Sleep(400);

                // 지우기 (같은 위치에 공백)
                Console.SetCursorPosition(textX, textY);
                Console.Write(new string(' ', startText.Length));

                Thread.Sleep(400);
            }

            int monstersKilled = 0;
                int input;
                int rnd;

                string Ing1 = "드래곤 꼬리";
                string Ing2 = "유니콘 뿔";
                string Ing3 = "가고일 날개죽지";
                string Ing4 = "골렘 가루";
                string Ing5 = "슬라임 점액질";
                string Ing6 = "고블린 고기";

            int rawMonster = 0;

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(startText);
            Console.ReadKey(true);
            Thread.Sleep(500);
            
                //무한반복
                while (true)
                {
                    Console.Clear(); //화면지우기
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(100);
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃    1.in to the Dungeon    ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃     2.Dungeon Kitchen     ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃    3.Dungeon Restaurant   ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃          4.Exit           ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                    Console.Write("입력 : ");
                    input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기
                    

                    if (input == 1) //나무캐기화면
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Thread.Sleep(100);
                            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                            Console.WriteLine("┃       ⚔️ Dungeon ⚔️       ┃");
                            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n===========Dungeon===========");
                            Console.WriteLine("\n이곳은 몬스터가 들끓는 던전입니다..");
                            Console.WriteLine("몬스터 사냥하기: Enter");
                            Console.WriteLine("뒤로가기: x");

                            string str = Console.ReadLine();
                            if (str == "x")
                            {
                                break;
                            }

                            rawMonster += 0;
                            Console.WriteLine("던전의 몬스터를 처치해 식재료를 얻으세요!");
                            Thread.Sleep(1000);
                            const int targetX = 26;
                            const int targetY = 11;
                            
                            Console.OutputEncoding = Encoding.UTF8;
                            int x = 23, y = 3;

                            ConsoleKeyInfo keyInfo;     //키 관련 정보

                            Console.CursorVisible = false;  //커서 안 보이게 하기

                            while (true)
                            {
                                Console.Clear();    //화면 지우기
                                
                                Console.WriteLine("■■□□■■■■□□■■■■■□□■■■■■■■■■■■■■■■■□□■■■■■■■■■□□■■■■■■■■■");
                                Console.WriteLine("■■■■□□□□□□□■■■■■■■■□□□■■■■■■□□□■■■■■■□□□■■■■■■■■□□□■■■■");
                                Console.WriteLine("■■□■■■□■■■□■■■■□■■■■□■■■□□■□□□□□■□■■■■□■■■□□□■■■■□■■■□□");
                                Console.WriteLine("    □□■■■■■■■■□□□■            □□■■■■■■■■□□□■");
                                Console.WriteLine("");
                                Console.SetCursorPosition(x, y); // 좌표
                                Console.Write("🤺");     // 현재 위치 출력
                                Console.SetCursorPosition(targetX, targetY);
                                Console.Write("👾");
                                
                                Console.WriteLine("\n            ■■■■■□□□■                 ■■■  ■□□□■");
                                Console.WriteLine("          □□■■■■■■■■□□□■            □□■■■■■■■■□□□■   ");
                                Console.WriteLine("■■■■□□□□□□□■■■■■■■■□□□■■■■■■□□□■■■■■■□□□■■■■■■■■□□□■■■■");
                                Console.WriteLine("■■□■■■□■■■□■■■■□■■■■□■■■□□■□□□□□■□■■■■□■■■□□□■■■■□■■■□□");



                                if (x == targetX && y == targetY)
                                {
                                    Console.Clear();
                                    Console.WriteLine("몬스터 원물을 획득했습니다.");
                                    rawMonster += 1;
                                    Console.WriteLine($"획득한 원물 수: {rawMonster}\n");
                                    Console.WriteLine("나가시겠습니까?: x");
                                    string exit = Console.ReadLine();
                                    if (exit == "x")
                                    {
                                        break;
                                    }
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
                                    

                                }
                                
                            } 
                                    
                            
                        }
                    }
                    else if (input == 2)
                    {
                        Console.Clear();
                    //장비뽑기
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃    🔪Dungeon Kitchen🔪    ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                        Console.WriteLine("\n===========KITCHEN===========");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n던전 주방에 오신 것을 환영합니다.");
                        Console.WriteLine("손질하기: Enter");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        
                        Console.WriteLine("원물을 손질해 식재료를 얻으세요!");
                        
                        string str2 = Console.ReadLine();
                        

                        if (rawMonster >= 10) //돈이 있는지 확인후 뽑기
                        {
                            rawMonster -= 10;

                            //20번 뽑기
                            for (int i = 1; i <= 10; i++)
                            {
                                rnd = rand.Next(1, 101);

                                if (rnd == 1) // 1퍼
                                {
                                    Console.WriteLine("@@@드래곤 꼬리@@@");
                                }
                                else if (rnd >= 2 && rnd <= 6)
                                {
                                    Console.WriteLine("!!유니콘 뿔!!");
                                }
                                else if (rnd >= 7 && rnd <= 17)
                                {
                                    Console.WriteLine("&가고일 날개죽지&");
                                }
                                else if (rnd >= 18 && rnd <= 38)
                                {
                                    Console.WriteLine("..골렘 가루..");
                                }
                                else if (rnd >= 39 && rnd <= 69)
                                {
                                    Console.WriteLine("~슬라임 점액질~");
                                }
                                else
                                {
                                    Console.WriteLine("고블린 고기");
                                }
                                Thread.Sleep(500); //0.5초정도로 뽑혀라.
                            }
                            Console.WriteLine("재료 손질이 완료되었습니다!");
                            Thread.Sleep(1000); 
                            
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다. \n");
                            Thread.Sleep(1000);
                        
                        }
                    }
                    else if (input == 3)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃  🏪 Dungeon Restaurant 🏪 ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n=========RESTAURANT=========");
                        Console.WriteLine("\n던전 레스토랑에 오신 것을 환영합니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("요리 시작하기: 1");
                        Console.WriteLine("뒤로가기 x"); 
                        input = int.Parse(Console.ReadLine());
                        if (input == 1)
                        {
                            Console.WriteLine("\n=======MENU=======");
                            Console.WriteLine("어떤 요리를 하시겠습니까?");
                            Console.WriteLine("\n1. 슬라임 푸딩");
                            Console.WriteLine("2. 고블린 야키토리");
                            Console.WriteLine("3. 두바이 골렘가루 쫀득쿠키");
                            Console.WriteLine("4. 고추장 가고일 날개 조림");
                            Console.WriteLine("5. 유니콘 뿔 오일 파스타");
                            Console.WriteLine("6. 드래곤 꼬리를 넣은 국물 요리");
                        }

                        string str = Console.ReadLine();
                        
                        for (int j = 1; j < 5; j++)
                        {
                            for (int k = 1; k < 5; k++)
                            {
                                rnd = rand.Next(1, 6);
                                Console.Write($"{Ing1}");
                            }
                        }
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }

                    }
                    
                    else if (input == 4)
                    {
                        Console.WriteLine("게임을 나갑니다.");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
            



                

                
        

        
    

