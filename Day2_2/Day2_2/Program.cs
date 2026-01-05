using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////실수 데이터 형식: 소수점 포함한 숫자 표현
            //float singlePrecision = 3.14f;
            //double doublePrecision = 3.1415926535;
            //decimal highPrecision = 3.1415926535897932384626433833m;

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);   
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //문자 데이터 형식: 단일 문자 저장하는 데이터 형식
            //2바이트 크기로 유니코드 표준 사용

            //char letter = 'H';
            //char symbol = '#';
            //char number = '1';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //출력
            //=== 캐릭터 능력지 ===
            //f이동속도 5.5f
            //d공격속도 1.25
            //


            float movingspeed = 5.5f;
            double attackspeed = 1.25;
            decimal itemPrice = 12.99m;
            
            Console.WriteLine("=== 캐릭터 능력치 ===");
            Console.WriteLine("이동속도: " + movingspeed);
            Console.WriteLine("공격속도: " + attackspeed);
            Console.WriteLine("아이템 가격: " + itemPrice);


        }
    }
}
