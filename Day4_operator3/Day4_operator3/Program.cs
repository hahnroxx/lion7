using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Day4_operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max);

            //삼항 연산자
            //(조건) ? t : f;

            //기본 사용법. 그런데 if 문이 가독성이 좋아서 그걸 많이 씀
            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine(result);

            //예제 2: 레벨에 따른 등급
            //레벨 45
            //int Level = 45;
            //string grade = (Level >= 50) ? "고급" : (Level >= 30) ? "중급 " : "초급";

            //Console.WriteLine("플레이어 등급");
            //Console.WriteLine($"레벨: " + Level);
            //Console.WriteLine($"등급: " + grade);


            //string grade = (Level >= 50) ?  "고급" :
            //               (Level >= 30) ?  "중급" : "초급";

            // health = 30;

            //int Health = 30;
            //double MaxHealth = 100;

            //string caution = (Health >= MaxHealth * 0.7) ? "안전" :
            //                 (Health >= MaxHealth * 0.3) ? "주의" : "위험";
            //Console.WriteLine("+++ 현재 상태 +++");
            //Console.WriteLine($"체력: {Health} / {MaxHealth}");
            //Console.WriteLine($"체력 등급: {caution}");

            //int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            //Console.WriteLine(result); // 출력: 20
            //int adjustedResult = (10 + 2) * 5; // 괄호로 우선순위 변경
            //Console.WriteLine(adjustedResult); // 출력: 60


            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage ) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0




        }
    }
}
