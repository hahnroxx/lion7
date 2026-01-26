using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG_DungeonBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var state = new GameState();

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.BufferWidth = 140;  // 120보다 크게
            Console.BufferHeight = 100;
            Console.SetWindowSize(80, 50);


            string startText = "⚔️ Press any key to start ⚔️ ";
            int textX = 13;
            int textY = Console.WindowHeight - 3;

            Console.WriteLine("게임 시작");
            Random rand = new Random();
            Console.ReadKey(true);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                    Dungeon BOB                     ┃");
            Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
            Console.WriteLine("┃                     Loading....                    ┃");
            Thread.Sleep(500);
            Console.WriteLine("┃                                                    ┃");
            Console.Write("┃                [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("■");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("■");
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("■");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("■");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("■");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("■");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("■");
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.White;
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

            Console.ReadKey(true);
            Thread.Sleep(500);

            GameState gamestate = new GameState();

            int monstersKilled = 0;
            int input;
            int rnd;
            //무한반복
            while (true)
            {
                Console.Clear(); //화면지우기
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(100);
                Console.WriteLine("┏━§━━━━━━━━━━━━━━━━━━━━━━━§━┓");
                Console.WriteLine("┃|   1.in to the Dungeon   |┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Thread.Sleep(100);

                Console.WriteLine();    
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("┏━§━━━━━━━━━━━━━━━━━━━━━━━§━┓");
                Console.WriteLine("┃|    2.Dungeon Kitchen    |┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Thread.Sleep(100);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("┏━§━━━━━━━━━━━━━━━━━━━━━━━§━┓");
                Console.WriteLine("┃|   3.Dungeon Restaurant  |┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Thread.Sleep(100);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("┏━§━━━━━━━━━━━━━━━━━━━━━━━§━┓");
                Console.WriteLine("┃|         4.Exit          |┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기


                if (input == 1) //나무캐기화면
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(100);
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃       ⚔️ Dungeon ⚔️       ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                        
                        Console.WriteLine("\n===========Dungeon===========");
                        Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n이곳은 몬스터가 들끓는 던전입니다..");
                        Thread.Sleep(500);
                        Console.WriteLine("몬스터 사냥하기: Enter");
                        Console.WriteLine("뒤로가기: x");

                        Console.OutputEncoding = Encoding.UTF8;

                        Console.CursorVisible = false;  //커서 안 보이게 하기

                        string str = Console.ReadLine();
                        if (str == "x")
                        {
                            break;
                        }
                        else
                        {
                            
                            Console.Clear();
                            Console.WriteLine("던전의 몬스터를 처치해 식재료를 얻으세요!");
                            DungeonScene dungeon = new DungeonScene(gamestate);
                            dungeon.Run();
                        }

                        Thread.Sleep(1000);



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
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n던전 주방에 오신 것을 환영합니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("원물을 손질해 식재료를 얻으세요!");
                    Console.WriteLine("손질하기: Enter");
                    Console.WriteLine("뒤로가기 x");

                    string str = Console.ReadLine();
                    new KitchenScene(gamestate, rand).Run();
                    if(str == "x") { break; }


                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                    Console.WriteLine("┃  🏪 Dungeon Restaurant 🏪 ┃");
                    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    
                    Console.WriteLine("\n=========RESTAURANT=========");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n던전 레스토랑에 오신 것을 환영합니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("요리 시작하기: 1");
                    Console.WriteLine("뒤로가기 x");

                    string str = Console.ReadLine();
                    new Restaurant(gamestate).Run();
                    if (str == "x") { break; }
                }

                else if (input == 4)
                {
                    Console.WriteLine("던전 출력 장비를 정지합니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
