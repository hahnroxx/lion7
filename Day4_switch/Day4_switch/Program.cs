using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day4_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////switch 문 연습하기
            //int day = 11;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 11:
            //        Console.WriteLine("한이 생일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일");
            //        break;
            //}

            //캐릭터 선택화면 만들기


            Console.WriteLine("=== 캐릭터 생성 ===\n");
            
            int JobChoice = 0;
            Console.WriteLine("클래스: 1. 전사, 2. 마법사, 3. 궁수, 4. 도적");
            Thread.Sleep(500);
            Console.WriteLine("클래스 형식을 입력하세요: ");
            JobChoice = int.Parse(Console.ReadLine());
            int BaseMana = 50;
            int BaseMagic = 10;
            switch (JobChoice)
            {
                case 1:
                    Console.WriteLine("\n클래스: 전사");
                    break;
                case 2:
                    Console.WriteLine("\n클래스: 마법사");
                    Thread.Sleep(500);
                    Console.WriteLine("특성: 강력한 마법 공격");
                    Thread.Sleep(500);
                    Console.WriteLine("주 무기: 지팡이, 마법서");
                    Thread.Sleep(500);
                    Console.WriteLine($"스탯: 마나 + {BaseMana + 50}, 마법력 + {BaseMagic + 10}");
                    break;
                case 3:
                    Console.WriteLine("클래스: 궁수");
                    break;
                case 4:
                    Console.WriteLine("클래스: 도적");
                    break;
            }
            Thread.Sleep(500);
            // 아이템 타입별 설명
            Console.WriteLine("\n=== 아이템 정보 ===");
            string itemType = "weapon";

            switch (itemType)
            {
                case "weapon":
                    Console.WriteLine("🗡️ 무기 - 공격력 증가");
                    break;
                case "armor":
                    Console.WriteLine("🛡️ 방어구 - 방어력 증가");
                    break;
                case "potion":
                    Console.WriteLine("🧪 물약 - 체력/마나 회복");
                    break;
                case "accessory":
                    Console.WriteLine("💍 장신구 - 특수 능력 부여");
                    break;
                default:
                    Console.WriteLine("❓ 알 수 없는 아이템");
                    break;
            }
            Thread.Sleep(500);
            // 요일별 이벤트
            Console.WriteLine("\n=== 오늘의 이벤트 ===");
            int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("🎁 일요일: 경험치 2배");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("📅 평일: 일반 보상");
                    break;
                case 5:
                    Console.WriteLine("💰 금요일: 골드 2배");
                    break;
                case 6:
                    Console.WriteLine("🎲 토요일: 아이템 드롭률 2배");
                    break;
                default:
                    Console.WriteLine("잘못된 요일");
                    break;
            }





        }
    }
}
