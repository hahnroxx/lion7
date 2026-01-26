using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG_DungeonBob
{
    internal class Restaurant
    {
        private readonly GameState _state;

        //레시피 정의
        

        public Restaurant(GameState state)
        {
            _state = state;
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n어떤 요리를 하시겠습니까?");
                Console.WriteLine("\n=======MENU=======");
                Console.WriteLine("\n1. 🫟슬라임 푸딩🫟");
                Console.WriteLine("\n2. 🍢고블린 야키토리🍢");
                Console.WriteLine("\n3. 🗿두개골 쫀득 쿠키🗿");
                Console.WriteLine("\n4. 🦇고추장 가고일 날개 조림🦇");
                Console.WriteLine("\n5. 🦄유니콘 뿔 크림 리조또🦄");
                Console.WriteLine("\n6. 🐉드래곤 꼬리를 넣은 국물 요리🐉");

                Console.WriteLine("\n요리 선택: (1~6)");
                Console.WriteLine("뒤로가기: x");

                // ✅ 입력 한 번만 받기
                string input = Console.ReadLine();

                if (input == "x")
                    break;

                // ✅ TryParse로 안전하게
                if (!int.TryParse(input, out int Recipe) || Recipe < 1 || Recipe > 6)
                {
                    Console.WriteLine("잘못된 입력입니다. 1~6 또는 x를 입력하세요.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.Clear();

                // 여기서부터 너의 레시피 안내 출력
                if (Recipe == 1)
                {
                    Console.WriteLine("- 🫟슬라임 푸딩 만들기🫟 -");
                    Console.WriteLine("\n필요 식재료 : 슬라임 점액질 2개");
                }
                else if (Recipe == 2)
                {
                    Console.WriteLine("- 🍢고블린 야키토리 만들기🍢 -");
                    Console.WriteLine("\n필요 식재료 : 고블린 살코기 3개");
                }
                else if (Recipe == 3)
                {
                    Console.WriteLine("- 🗿두개골 쫀득 쿠키 만들기🗿 -");
                    Console.WriteLine("\n필요 식재료 : 골렘 가루 2개, 슬라임 점액질 1개");
                }
                else if (Recipe == 4)
                {
                    Console.WriteLine("- 🦇고추장 가고일 날개 조림 만들기🦇 -");
                    Console.WriteLine("\n필요 식재료 : 가고일 날개죽지 1개, 골렘 가루 1개, 슬라임 점액질 2개");
                }
                else if (Recipe == 5)
                {
                    Console.WriteLine("- 🦄유니콘 뿔 크림 리조또 만들기🦄 -");
                    Console.WriteLine("\n필요 식재료 : 유니콘 뿔 2개, 골렘 가루 1개, 고블린 살코기 1개, 슬라임 점액질 1개");
                }
                else // Recipe == 6
                {
                    Console.WriteLine("- 🐉드래곤 꼬리를 넣은 국물 요리 만들기🐉 -");
                    Console.WriteLine("\n필요 식재료 : 드래곤 꼬리 1개, 유니콘 뿔 1개, 골렘 가루 2개, 고블린 살코기 2개, 슬라임 점액질 3개");
                }

                Thread.Sleep(500);
                Console.WriteLine("\n(아직) 식재료 체크/소비 로직이 없어서 일단 안내만 출력.");
                Console.WriteLine("\n아무 키나 누르면 메뉴로 돌아갑니다.");
                Console.ReadKey(true);
            }
        
    
        }
    }
}
