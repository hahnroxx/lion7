using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////상수 사용하기
            //const double Pi = 3.14159265358979; //상수 pi 선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max Score: " +  MaxScore);

            //**실행결과 : **
            //```
            //=== 게임 설정 ===
            //최대 플레이어: 4명
            //시작 골드: 1000G
            //버전: 1.0.0
            //```

            const int MaxPlayer = 4;
            const int Gold = 1000;
            const string Version = "1.0.0";

            Console.WriteLine("===게임 설정===");
            Console.WriteLine("```");
            Console.WriteLine("최대 플레이어:" + MaxPlayer + "명");
            Console.WriteLine("시작 골드:" + Gold + "G");
            Console.WriteLine("버전:" + Version);
            Console.WriteLine("```");

            //강사님 답안
            // 게임 설정 상수
            const int MAX_PLAYER_COUNT = 4;      // 최대 플레이어 수
            const int STARTING_GOLD = 1000;      // 시작 골드
            const double PI = 3.14159;           // 원주율
            const string GAME_VERSION = "1.0.0"; // 게임 버전

            // 상수 사용
            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine($"최대 플레이어: {MAX_PLAYER_COUNT}명");
            Console.WriteLine($"시작 골드: {STARTING_GOLD}G");
            Console.WriteLine($"버전: {GAME_VERSION}");

        }
    }
}
