using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day5_blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //타이틀
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃      벌목꾼 키우기     ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━┛");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(1000);



            ////랜덤
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("┏━━━━━━━━━━━━┓");
            //    Console.WriteLine("┃   1.벌목   ┃");
            //    Console.WriteLine("┗━━━━━━━━━━━━┛");

            //    Console.WriteLine("┏━━━━━━━━━━━━━━┓");
            //    Console.WriteLine("┃  2.장비 뽑기 ┃");
            //    Console.WriteLine("┗━━━━━━━━━━━━━━┛");

            //    Console.WriteLine("┏━━━━━━━━━━━━━━┓");
            //    Console.WriteLine("┃   3.나가기   ┃");
            //    Console.WriteLine("┗━━━━━━━━━━━━━━┛");

            //    Console.Write("입력: ");
            //    input = int.Parse(Console.ReadLine());

            //    if (input == 1)
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("벌목(엔터)");
            //            Console.WriteLine("뒤로 가기 x");

            //            string str = Console.ReadLine();

            //            PMoney += 100;
            //            Console.WriteLine($"소지금: {PMoney} G");
            //            if (str == "x") ;
            //            {
            //                Console.WriteLine("뒤로 가기");
            //                break;
            //            }
            //        }

            //    }
            //    else if (input == 2)
            //    {
            //        //장비 뽑기
            //        if (PMoney >= 1000)
            //        {
            //            PMoney -= 1000;

            //            //20번 뽑기
            //            for (int i = 1; i <= 20; i++)
            //            {
            //                rnd = rand.Next(1, 101);

            //                if (rnd == 1)
            //                {
            //                    Console.WriteLine("도끼등급 SSS");
            //                }
            //                else if (rnd == 2 && rnd <= 6)
            //                {
            //                    Console.WriteLine("도끼등급 SS");
            //                }
            //                else if (rnd == 7 && rnd <= 17)
            //                {
            //                    Console.WriteLine("도끼등급 S");
            //                }
            //                else if (rnd == 18 && rnd <= 38)
            //                {
            //                    Console.WriteLine("도끼등급 A");
            //                }
            //                else if (rnd == 39 && rnd <= 69)
            //                {
            //                    Console.WriteLine("도끼등급 SS");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("도끼등급 C");
            //                }
            //                Thread.Sleep(100);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("돈이 부족합니다! \n");
            //            Thread.Sleep(500);
            //        }

            //    }
            //    else if(input ==3)
            //    {
            //        Console.WriteLine("게임을 종료합니다");
            //        Environment.Exit(0);
            //    }

            while (true)
            {
                Console.Clear(); //화면지우기
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

                if (input == 1) //나무캐기화면
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }


                    }
                }
                else if (input == 2)
                {
                    //장비뽑기
                    if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1) // 1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(100); //0.5초정도로 뽑혀라.

                        }


                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임을 나갑니다.");
                    Environment.Exit(0);
                }


            }



        }
    }
}
