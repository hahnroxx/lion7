using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D 게임맵



            //Console.OutputEncoding = Encoding.UTF8;
            //int[,] map = new int[5, 5]
            //{
            //     { 0,0,1,0,0},
            //     { 0,2,1,0,3},
            //     { 0,0,1,0,0},
            //     { 1,1,1,0,0},
            //     { 0,0,0,0,9},
            //};

            //Console.WriteLine("==== Dungeon Map ====");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("=== 성적표 ===\n");


            int[,] grade = new int[3, 4]
            {
                { 85,90,88,92,},
                { 78,85,90,87,},
                { 92,88,95,90,}
            };
            string[] names = { "김철수", "이영희", "박민수" };
            string[] subjects = { "국어", "영어", "수학", "과학" };
            Console.Write("이름\t");
            foreach (string subject in subjects)
            {
                Console.Write($"{subject}\t");
            }
            Console.WriteLine("평균");
            for (int i = 0; i < grade.GetLength(0); i++)
            {
                Console.Write($"{names[i]}\t");
                int sum = 0;
                for (int j = 0; j < grade.GetLength(1); j++)
                {
                    Console.Write($"{grade[i, j]}\t");
                    sum += grade[i, j];
                }

                double average = (double)sum / grade.GetLength(1);
                Console.WriteLine($"{average:F1}");
            }
            Console.WriteLine();
            Console.WriteLine("\n=== 과목별 평균 ===");
            Console.WriteLine();
            for (int subject = 0; subject < grade.GetLength(1); subject++)
            {
                int sum = 0;
                for (int student = 0; student < grade.GetLength(0); student++)
                {
                    sum += grade[student, subject];
                }
                double avg = (double)sum / grade.GetLength(0);
                Console.WriteLine($"{subjects[subject]}: {avg:F1}점");

            }
        }
    

        
    }
}
