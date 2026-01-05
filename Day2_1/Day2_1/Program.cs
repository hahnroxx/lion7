using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int integerNum = 10;    //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.141592;    //배정밀도 실수

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //int 아무거나 = 10000;

            //Console.WriteLine(아무거나);

            int intValue = -100;
            long longValue = 1234567890L;
            byte level = 50;    //(0~255까지만 씀)
            short attack = 1500;
            int gold = 123456789;
            long experience = 999999999L;

            Console.WriteLine("===캐릭터 정보===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드"); //NO: 천단위 콤마 구분
            Console.WriteLine($"경험치: {experience:N0}");
                
            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            Console.WriteLine("\n===타입별 최대값===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue}");
            Console.WriteLine($"long 최대값: {long.MaxValue}");




        }
    }
}
