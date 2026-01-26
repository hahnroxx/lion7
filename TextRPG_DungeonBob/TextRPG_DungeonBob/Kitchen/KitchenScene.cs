using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextRPG_DungeonBob
{
    internal class KitchenScene
    {
        private readonly GameState _gameState;
        private readonly Random _rand;

        //비용(원물 몇개로 손질 1회)
        private const int Cost = 10;
        private const int Press_Count = 10;     //한번 손질에 몇 번 뽑을지

        public KitchenScene(GameState gameState, Random rand)
        {
            _gameState = gameState;
            _rand = rand;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"\n현재 원물 개수: {_gameState.RawMonster}");
                Console.WriteLine("\n원물 손질하기(10개 소모): Enter");
                Console.WriteLine("뒤로가기: x ");

                string str = Console.ReadLine();
                if (str == "x")
                {
                    break;
                }
                
                
                _gameState.RawMonster += 10;

                if(_gameState.RawMonster >= 10)
                {
                    
                    _gameState.RawMonster -= 10;

                    //10번 뽑기
                    for (int i = 0; i < 10; i++)
                    {
                        int rnd = _rand.Next(1, 101);

                        string item;
                        if (rnd <= 2)   //2%
                            item = "@@@드래곤 꼬리@@@";
                        else if (rnd <= 7)  //5%
                            item = "^*유니콘 뿔*^";
                        else if (rnd <= 18)     //10%
                            item = "+=가고일 날개죽지=+";
                        else if (rnd <= 39)     //20%
                            item = ";:골렘 가루:;";
                        else if (rnd <= 70)     //30%
                            item = "&고블린 살코기&";
                        else                    //33%
                            item = "~슬라임 점액질~";

                        Console.WriteLine(item);

                        _gameState.AddIngred(item, 1);

                        Thread.Sleep(500);
                    }
                    Console.WriteLine("\n재료 손질이 완료되었습니다!");

                }
                else
                {
                    Console.WriteLine("원물이 부족합니다. 몬스터를 사냥하세요!");
                }
            }
        }
    }
}
