using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ////배열 ->> 짱 효율적
            ////배열 선언 방법
            ////방법 1.
            //int[] scores = new int[5];  //int들 5개 들어갈 사물함 만듦!

            ////방법 2: 초기값과 함께 선언
            //int [] numbers = new int[] { 1, 2, 3, 4, 5 };

            ////방법 3: 간단 초기화
            //int[] values = {1,2, 3, 4,5};

            ////방법 4
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;
            ////*scores[5] = 6;  //->이거는 안된다. 박스에 int 5개만 들어가니까!
            ////박스의 허용 범위보다 많이 만들면, out of range 오류가 뜨면서 출력 오류.

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //인벤토리 시스템 (최대 5개)
            //string[] items = new string[5];

            //items[0] = "드래곤 꼬리";
            //items[1] = "유니콘 뿔";
            //items[2] = "골렘 가루";
            //items[3] = "슬라임 점액질";
            //items[4] = "고블린 고기";

            ////인벤토리 출력
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}].{items[i]}");
            //}

            ////인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}


            ////특정 아이템 사용
            //Console.WriteLine($"{inventory[0]}를 사용했습니다!");
            //inventory[0] = "(비어있음)";

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //Console.WriteLine("=== 캐릭터 스탯 ===");
            //int[] stats = new int[5];
            //stats[0] = 100;
            //stats[1] = 50;
            //stats[2] = 80;
            //stats[3] = 60;
            //stats[4] = 45;
            //string[] statNames = { "HP", "MP", "공격력", "방어력", "민첩" };

            //for (int i = 0; i < stats.Length; i++)
            //{
            //    Console.WriteLine($"{statNames[i]}: {stats[i]}");
            //}

            //Console.WriteLine("==== 일일 퀘스트 진행도 ====");
            //string[] Monsters = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int QuestGoal = 5;
            //int[] Prog = { 5, 3, 8, 2, 7 };

            //for (int i = 0; i < Prog.Length; i++)
            //{ 
            //    Console.Write($"{Monsters[i]}: {Prog[i]}/{QuestGoal}    ");
            //    if (Prog[i] >= QuestGoal)
            //    {
            //        Console.WriteLine("완료!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("진행 중...");
            //    }


            //}

            int[] scores = { 85, 92, 78, 95, 88 };

            //배열 길이
            Console.WriteLine("총 점수 개수: " + scores.Length);

            //배열 순회
            Console.WriteLine("개별 점수");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"플레이어{i + 1}: {scores[i]}점");
            }
            
            //합계 계산
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine($"\n총점: {sum}점");
            Console.WriteLine($"평균: {(float)sum / (float)scores.Length}점");

            Console.WriteLine();
            //최고점 찾기
            int MaxScore = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > MaxScore)
                {
                    MaxScore = scores[i];
                }
            }
            Console.WriteLine($"최고점: {MaxScore}");
            //최저점 찾기
            int MinScore = scores[0];
            for (int i =0; i < scores.Length; i++)
            {
                if (scores[i] < MinScore)
                {
                    MinScore = scores[i];
                }
            }
            Console.WriteLine($"최저점: {MinScore}");

            //Array 클래스 메서드 활용
            Console.WriteLine("==== Array 메서드 ====");

            //정렬 (기본적으로 오름차순{작->큰}이 적용된다)
            int[] sortedScores = (int[])scores.Clone();
            Array.Sort( sortedScores );
            Console.WriteLine("정렬 후: ");

            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            Array.Reverse(sortedScores);
            Console.WriteLine("역순 : ");

            for (int i = 0;i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            foreach (int score in sortedScores)
            {
                Console.WriteLine(score);
            }

            int SearchScore = 92;
            int index = Array.IndexOf(scores, SearchScore);
            Console.WriteLine($"{SearchScore}점의 위치: 인덱스 {index}");
            Console.WriteLine($"찾은 값: {scores[index]}");





        }
    }
}
