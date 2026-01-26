using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG_DungeonBob
{
    internal class DungeonScene
    {
        private readonly GameState _state;
        private readonly Map _map;

        public DungeonScene(GameState state)
        {
            _state = state;
            // 너가 쓰던 좌표 그대로
            _map = new Map(playerX: 4, playerY: 2, monsterX: 36, monsterY: 6);
            Console.CursorVisible = false;
        }
        public void Run()
        {
            while (true)
            {
                _map.DrawMap();

                if (_map.IsPlayerOnMonster())
                {
                    bool won = Battle.StartBattle(_state);

                    Console.WriteLine("Enter: 계속 사냥 / x: 나가기");

                    string input = Console.ReadLine();
                    if (input == "x")
                        break;

                    
                    _map.SpawnMonster(50, 17);
                    Console.Write("🧟");
                    continue;
                }

                // 키 입력
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.X)
                    break;

                _map.MovePlayer(keyInfo.Key);
                Thread.Sleep(20);
            }

            Console.CursorVisible = true;
        }
    }
}
