using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day3_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////연산자 이해하기
            //int a = 5, b = 10;
            //int sum = a + b;
            //bool isEqual = (a == b);

            //Console.WriteLine($"a와 b의 합: {sum}");
            //Thread.Sleep(500);
            
            //Console.WriteLine($"그러면 a와 b는 같은가? {isEqual}");
            //Thread.Sleep(2000);

            ////단항 연산자
            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);
            //Thread.Sleep(1000);
            //bool flag = true;
            //Console.WriteLine(!flag);

            ////산술 연산자
            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //문자열 연결 연산자

            //string firstName = "Hahn";
            //string lastName = "Kim";

            //Console.WriteLine(firstName + " " + lastName);


            //할당 연산자
            int a = 5;
            int b = 4;

            a += b;
            Console.WriteLine("덧셈 : " +  a);

            //-
            a = 5;
            a -= b;
            Console.WriteLine("뺄셈 : " + a);

            //*
            a = 5;
            a *= b;
            Console.WriteLine("곱셈 : " + a);

            // / 
            a = 5;
            a /= b;
            Console.WriteLine("나눗셈 : " + a);

            a = 5;
            a %= b;
            Console.WriteLine("나머지 : " + a);

            string firstname = "hahn";
            string lastname = " kim";

            firstname += lastname;
            Console.WriteLine("Full Name: " + firstname);
            










        }
    }
}
