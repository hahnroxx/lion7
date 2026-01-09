using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace Day5_2dmnsnfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //2차원 포문이다.
            //for 아래에 for 한번 더써주는 것
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }


            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("=== 예제 6: 2단 곰셉표 ===");

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i * j} ");
            //    }
            //    Console.WriteLine();
            //}

            ////피라미드 만들기
            //Console.WriteLine("=== pyramid ===");
            //for (int i = 0; i <= 8; i++)
            //{
            //    for (int j = 9; j > i ; j--)
            //    {
            //        for (int k = 0; k <= 8; k++)
            //        {

            //            if (k <= i)
            //            {
            //                Console.Write("*");
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("=== 미니 게임 맵 ===");
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("🏠 ");
                        
                    }
                    else if (i == 3 && j == 3)
                    {
                        Console.Write("🎯 ");
                        
                    }
                    else
                    {
                        Console.Write("🟩 ");
                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
