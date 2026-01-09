using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while(i < 9)
            //{
            //    Console.WriteLine("숫자: "+ i);
            //    Thread.Sleep(100);
            //    i++; //중괄호 안에 증감식 넣어줘야함
            //}

            //10부터 1까지 카운트 다운하기

            //int i = 10;
            //while(i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //    Thread.Sleep(100);
            //}



            //Console.WriteLine("=== 예제 3: 합계 구하기");
            //int sum = 0;
            //int i = 1;

            //while (i < 5)
            //{

            //    sum = sum + i;
            //    i++;
            //    Console.WriteLine($"{sum - 1} + {i} = {sum}");

            //}



            // 예제 4. 목표 달성하기
            //Console.WriteLine("=== 목표 달성하기 ===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while (coins < target)
            //{
            //    coins = day * 10;
            //    Console.WriteLine($"{day}일차: 코인 {coins}개 획득!");
            //    day++;
            //}
            //Console.WriteLine($"목표 달성! {day}일 걸렸습니다.");




            //do - while

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한번 실행됩니다");
            //    x--;
            //} while (x > 0);

            //string Choice;
            //int TotalPrice = 0;

            

            //do
            //{
            //    Console.WriteLine("=== 메뉴판 ===");
            //    Console.WriteLine("1. 짜장면 - 5000원");
            //    Console.WriteLine("2. 짬뽕 - 6000원");
            //    Console.WriteLine("3. 볶음밥 - 5500원");
            //    Console.WriteLine("4. 탕수육 - 11000원");
            //    Console.WriteLine("0. 주문 완료");
            //    Console.WriteLine("=============");
            //    Console.WriteLine("메뉴 번호를 입력하세요: \n");

            //    Choice = Console.ReadLine();

            //    //메뉴 선택 처리
            //    switch (Choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5000원)");
            //            TotalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짬뽕 추가! (+6000원)");
            //            TotalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("볶음밥 추가! (+5500원)");
            //            TotalPrice += 5500;
            //            break;
            //        case "4":
            //            Console.WriteLine("탕수육 추가! (+11000원)");
            //            TotalPrice += 11000;
            //            break;
            //        case "0":
            //            Console.WriteLine("감사합니다!");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");
            //            break;


            //    }
            //    if (Choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {TotalPrice:N0}원\n");
            //    }
            //    else
            //        Console.WriteLine("주문 완료!");
            //} while (Choice != "0");

            
            //Console.WriteLine($"총 금액: {TotalPrice}원");
            
        }
    }
}
