using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day3_Readline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열로 받기
            //Console.WriteLine("이름을 입력하세요:");
            ////혹은 그냥 Write 써도 됨
            //String userName = Console.ReadLine();   //사용자로부터 입력 받기
            //String password = Console.ReadLine();
            ////이렇게 하고 사용자가 이름, 비번 입력하면 아래 문장이 출력됨
            //Console.WriteLine($"안녕하세요, {userName}님!");



            //Console.WriteLine("나이를 입력하세요:");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");



            //이진수를 정수로 변환
            //Console.WriteLine("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수: {binaryOutput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");



            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"환영합니다, {userName}님!");
            //Thread.Sleep(1000);
            //Console.Write("\n시작 레벨을 입력하세요: ");
            //int startLevel = int.Parse( Console.ReadLine() );

            //Console.WriteLine($"\n{userName}님의 시작레벨은 {startLevel}입니다!");
            //Thread.Sleep(1000);
            //Console.WriteLine("\n게임을 계속하려면 아무 키나 누르십시오");
            //Thread.Sleep(1000);


            //var 사용하기
            //var name = "HahnKim";
            //var age = 100;
            //var isStudent = true;
            //var Pi = 3.14;

            //Thread.Sleep(1000);
            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");



            //default 키워드 사용하기
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");



            //암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber;   //int -> long은 자동 변환됨
            double doubleNumber = smallNumber;  //int -> double 자동 변환

            Console.WriteLine("=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber}");
            Console.WriteLine($"long: {bigNumber}");
            Console.WriteLine($"double: {doubleNumber}");

            //명시적 변환 (큰 타입 -> 작은 타입)
            double Pi = 3.141592;
            int intPi = (int)Pi; //소수점 버림!(명시적 변환 필요)

            Console.WriteLine("=== 명시적 변환 ===");
            Console.WriteLine($"double: {Pi}");
            Console.WriteLine($"int로 변환 : {intPi}");


            //3. 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText);

            string priceText = "19.99";
            double price = double.Parse(priceText);

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"정수(문자열): {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열): {priceText} -> 숫자: {price}");


            //4. 숫자를 문자열로 변환
            int playerLevel = 100;
            string levelText = playerLevel.ToString();

            Console.WriteLine("\n=== 숫자를 문자열로 ===");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열: {levelText}");














        }
    }
}
