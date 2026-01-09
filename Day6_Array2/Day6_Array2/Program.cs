using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////2차원 배열
            //// 방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //{ 1, 2, 3 },
            //{ 4, 5, 6 }
            //};

            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{
            //{ 90, 85, 88 },
            //{ 92, 78, 95 },
            //{ 87, 91, 84 }
            //};

            //int[,] array = new int[3, 4];
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)  - GetLength: 길이(개수) 파악해라!
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2 - Rank: 차원


            //좌석 배치도
            Console.WriteLine("=== 좌석 배치도 ===");
            string[,] array = new string[3, 3]
            {
                {"A1", "A2", "A3" },
                {"B1", "B2", "B3" },
                {"C1", "C2", "C3" }
            };

            for (int row = 0; row < array.GetLength(0); row++)    // 행(row) 반복
            {
                for (int col = 0; col < array.GetLength(1); col++)    // 열(column) 반복
                {
                    Console.Write($"[{array[row, col]}] ");
                }
                Console.WriteLine();
            }
            string searchArray = "A1";
            string index = Array.IndexOf(array, searchArray);
            //첫번째 좌석 : A1


            
        }
    }
}
