using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_DungeonBob
{
    internal class Map
    {
        public int MinX { get; } = 0;
        public int MaxX { get; } = 120;
        public int MinY { get; } = 0;
        public int MaxY { get; } = 40;

        public int PlayerX { get; private set; }
        public int PlayerY { get; private set; }

        public int MonsterX { get; private set; }
        public int MonsterY { get; private set; }

        

        public Map(int playerX, int playerY, int monsterX, int monsterY)
        {
            PlayerX = playerX;
            PlayerY = playerY;
            MonsterX = monsterX;
            MonsterY = monsterY;

            
        }
        public void SpawnPlayer(int x, int y)   //플레이어 생성
        {
            PlayerX = x;
            PlayerY = y;
        }
        public void SpawnMonster(int x, int y)  //몬스터 생성
        {
            MonsterX = x;
            MonsterY = y;
        }


        public bool IsPlayerOnMonster()
        {
            return PlayerX == MonsterX && PlayerY == MonsterY;
        }


        //플레이어 이동 함수
        public void MovePlayer(ConsoleKey key)
        {

            int nx = PlayerX;
            int ny = PlayerY;

            

            switch (key)
            {
                case ConsoleKey.UpArrow: ny--; break;
                case ConsoleKey.DownArrow: ny++; break;
                case ConsoleKey.LeftArrow: nx--; break;
                case ConsoleKey.RightArrow: nx++; break;
            }

            // 경계 체크(맵 밖 못 나가게)
            if (nx < MinX) nx = MinX;
            if (nx > MaxX) nx = MaxX;
            if (ny < MinY) ny = MinY;
            if (ny > MaxY) ny = MaxY;

            PlayerX = nx;
            PlayerY = ny;

            //벽 충돌 구현...가능할까?
            
        }


        
        public void DrawMap()
        {
            Console.Clear();
            Console.WriteLine("⡽⡯⡿⡽⣯⢿⡽⣯⢷⣻⣞⣷⣻⣞⣷⣻⣞⡈⠀⠂⠀⠄⠂⠁⣯⢿⣽⣻⣞⣷⣻⣞⣷⣻⡽⣯⢿⣽⣻⣗⣟⣞⣷⣻⣞⣾⣳⡯⣟⣷⣻⣞⡷⣯⢿⢽⣻⣺⣗⣯⣯⢷⣻⣞⡷⣯⣟⣷⣻⣽⣞⣷⣻");
            Console.WriteLine("⣿⢽⣟⡿⣽⢯⢿⢽⢯⢷⡻⣞⢷⡀⠂⢀⠁⠐⠀⠂⠁⡀⡀⡿⡽⡻⣞⢷⡻⣞⢷⡻⣞⢷⣻⢽⡻⣞⢷⡻⡾⡽⣞⢷⡻⣞⢷⣻⡻⣞⢷⢯⢿⢽⢯⢿⢽⢞⡷⣻⢞⣟⡷⣯⣟⣷⣻⣞⡷⣗⣿⣺⣗");
            Console.WriteLine("⣽⣻⣞⣯⢿⡽⡯⠁⡀⠄⠀⠄⠂⠐⠀⡈⠀⠂⠀⠄⠂⠁⡀⠂⢀⠁⠐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠠⠀⠂⢀⠐⠈⠀⠄⠐⠂⣯⣟⣷⣻⣞⣗⣯⢿⡽⣞⣷⣻");
            Console.WriteLine("⣞⣗⣿⣺⡯⣟⡯⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠁⠐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠈⢀⠁⢈⠠⠐⠀⠠⠀⠠⢐⠠⢁⢷⣻⣞⣷⣻⢾⡽⣯⢿⡽⣾⢽");
            Console.WriteLine("⣳⣟⠊⡓⢋⢋⠫⠀⠠⠈⢀⢐⢔⢄⠕⣔⠰⡐⡐⢔⢐⢔⢐⢅⢆⢢⢱⠁⠂⠁⢈⠀⠠⠈⢀⠠⢊⠢⡂⠕⡌⡔⢔⣐⠰⡐⡈⡂⡂⡂⠠⠀⠂⢀⠐⠈⠀⠄⠐ ⠐⡙⡓⡙⡊⡋⡋⡋⡋⡋⡋⢫⡿");
            Console.WriteLine("⡿⡮⢐⠁⠐⠀⠂⠁⡀⠂⢊⠰⣱⢰⢅⡃⢇⢣⢑⠔⡡⢂⠕⡌⡢⢣⢪⠐⡠⠡⠐⢨⠐⡈⡐⢐⢘⢬⢌⠪⡪⢢⠣⡢⡃⣎⢔⢀⠐⠈⢀⠀⠂⡀⠄⠠⠀⠂⢀⠐⠄⠠⠀⠂⢀⠐⠈⠀⠈⢔⠨⢸⢯");
            Console.WriteLine("⣯⣟⠐⠀⠂⠁⡀⠂⡁⠢⢐⢘⠰⢠⢱⠱⡱⡑⡔⣱⠨⡢⡱⡸⡨⣘⢜⠄⡂⢌⠨⢐⢐⢐⠠⢁⢌⢢⢡⢱⢸⢰⠡⡑⢌⠢⡑⡠⠊⡐⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠠⢐⠨⡐⠅⢅⢂⢊⠌⡂⡊⡸⣯");
            Console.WriteLine("⣺⣗⠐⠈⢀⠐⠈⢀⢀⠑⠠⢘⢍⢊⠢⡑⡥⣣⡣⡳⣝⢜⡜⣜⢼⡸⣜⢜⣒⣒⣸⢐⢔⣒⣸⣐⢌⢮⢪⢎⢧⣣⠱⠨⢒⠑⡕⡕⡁⡂⠅⠰⢐⠠⠁⢅⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠁⠐⠠⠀⠂⢿");
            Console.WriteLine("⡷⣗⠠⠐⠈⢀⠀⠂⡀⠑⠄⠸⡐⢔⠡⡂⡪⡺⡼⡕⡗⣗⣝⡼⡵⣝⡮⣫⢫⢛⢺⠡⡛⡝⡺⡹⢸⡪⣞⡽⡭⡎⢜⠨⢢⠡⢣⢣⠂⡂⠡⢑⠐⡈⠌⡠⢘⠠⢈⠂⠔⢰⢸⡸⡰⣲⠰⠨⡐⢌⢐⢸⢯");
            Console.WriteLine("⣟⣗⡀⠂⠁⢈⠀⠠⠈⢀⠠⢕⠌⢆⢣⢑⢭⢺⢺⢪⢺⢚⢺⠸⡹⡱⢱⢊⠐⠀⠠⠀⠠⠐⠈⢀⢸⢙⢕⠝⡝⢜⢌⠪⡢⡑⡱⡡⠡⡂⠅⢆⠥⡢⡡⡂⢆⠊⡐⠨⢐⢘⢜⢜⠮⡺⡸⡨⡐⡐⡐⢸⣯");
            Console.WriteLine("⡽⣞⠠⢁⢐⠄⠂⢀⠁⠐⠀⢸⠡⡃⢎⠢⣊⢯⢸⣺⢸⢸⠈⢀⠁⠐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⠈⢀⠠⠐⠀⢀⠅⡇⢆⠕⡩⣊⠪⡐⡑⢅⠣⡱⢘⢌⠢⢁⠂⠅⢂⢘⢦⢧⡳⡵⡇⡇⡢⠐⡐⢸⢾");
            Console.WriteLine("⣯⢷⠀⠂⡀⠄⠠⠀⠂⢀⠀⡸⢌⠜⢌⠪⢸⢝⡳⣙⣓⢏⠨⡈⠀⠂⠀⠄⠂⠁⡀⠂⡈⠁⡀⠂⠢⢊⢀⢂⢐⠨⡊⢌⢢⠱⡸⡐⢕⢬⢘⢔⢕⢜⢔⡂⡇⡂⢌⠨⠠⢸⣸⣣⣫⡺⡕⡕⡐⡈⢄⢸⣯");
            Console.WriteLine("⡾⡯⡀⠂⠁⢈⠀⠠⠈⢀⡐⢨⢢⢃⠇⡊⡪⡪⡐⠀⠠⠈⢀⠠⠐⠀⠠⠀⡢⡩⣆⣃⢇⠖⠬⡐⢜⣌⣎⢜⢔⢕⢌⢎⢢⢣⢺⢸⡱⡹⣪⢪⡪⡎⡧⡣⡣⡣⡂⠌⡐⢐⢐⠰⠢⠪⠪⠪⢐⠐⠠⢸⣞");
            Console.WriteLine("⣟⡯⢀⠀⠂⡀⠄⠠⠀⠂⢀⢸⢐⡑⢌⢒⠜⡌⡂⠐⠈⢀⠀⠂⡀⠄⢕⢕⠪⡘⠔⢔⠅⢕⢅⢣⢱⢡⢊⠎⢌⢇⢪⠨⣊⢢⢫⡳⣝⠼⣕⢷⢕⡵⡭⣝⢮⠪⡐⢈⢐⢀⠀⠂⡀⠄⠠⠀⢀⠀⠌⢸⣞");
            Console.WriteLine("⣯⡯⠠⠐⠀⠠⠀⠠⠠⠐⠀⠸⡐⢌⠪⡐⢕⢕⠡⠂⠁⡀⠂⢀⠁⠐⠂⡐⡑⡌⣊⡢⡧⣳⢜⢴⢜⢷⢝⣞⢮⡫⣺⢺⢮⡳⣫⢪⢪⠳⡱⢫⢫⢪⢫⢪⢣⠣⡊⠀⠂⢀⠐⠈⠀⠄⠐⠀⠂⢀⠊⢸⣞");
            Console.WriteLine("⣷⡻⠠⢀⠠⠐⠀⠠⠀⠠⠐⠈⡍⡢⢑⠌⢜⠔⠅⠐⠀⠂⠁⡀⠐⢈⢸⢘⢌⠢⡢⡸⣽⡪⣗⢽⡺⡵⣝⢼⢾⣜⡮⡯⣺⣪⢗⠥⡡⠡⠡⢑⠡⢈⠂⠅⢊⠌⡐⠨⢈⢐⠨⠠⢁⢂⢑⠐⡈⡐⡈⢸⣳");
            Console.WriteLine("⣞⣯⠨⠠⠀⠂⠁⡀⠂⠁⢈⠨⡒⢜⢰⡁⡇⡝⡐⠠⠐⠀⠂⠁⡀⠁⢔⢕⢐⠕⡐⡱⣕⢯⡺⢽⢺⢽⠾⡵⣳⡳⣝⡾⡵⢯⡳⡱⢐⠨⢐⢐⠨⠐⡈⠌⡐⡰⡕⡝⣆⠢⡈⢂⠡⢀⠢⡈⠄⡂⢄⢱⣟");
            Console.WriteLine("⣻⢾⣸⣜⣼⣸⣜⢨⠠⠀⠂⢪⢪⣣⢳⡣⡳⣱⡡⣃⣢⠠⠐⠀⠠⠀⢌⠢⠢⡑⡌⢮⢢⠣⠪⠪⠪⡊⠎⡪⠢⠣⠣⡊⠎⢆⠣⠣⡁⢂⢂⠰⠈⠔⠠⠡⢐⢸⠬⡨⡎⡐⠄⡡⠨⠐⡐⠄⡁⡂⠔⢸⢾");
            Console.WriteLine("⡽⣯⢷⣻⣞⣷⣳⠠⠀⠂⠠⢸⡱⡵⠵⡝⣞⢜⡏⡟⡺⡑⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⠄⠂⠁⡀⠂⢀⠁⠐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠌⠨⡁⠢⠨⡏⢮⠣⠨⢐⠠⠨⢐⠠⡁⡂⠔⢈⢸⡽");
            Console.WriteLine("⢿⡽⣯⢷⣻⣞⣗⠠⠡⠨⢈⢸⠸⡹⡱⡹⢪⢪⠐⠀⠂⠁⡀⠂⠁⢈⠰⡱⣸⢰⢱⢸⢨⠂⠀⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠠⠀⠠⠀⠠⠐⠈⢀⠀⠂⡀⠄⠠⠡⢈⠢⢑⡀⠂⠁⢈⠀⠠⠈⢀⡔⣸⣽");
            Console.WriteLine("⢿⡽⣯⣟⣷⣻⣞⠠⢁⠊⠂⡀⠄⠠⠀⠂⠂⡀⠄⠠⠀⠂⠂⡀⠄⠨⢘⢼⢺⢸⡪⣎⢎⠌⡐⡁⢅⢱⢵⢸⢔⢕⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⠐⠈⢀⡀⠂⢔⢬⣺⢸⢔⢸⣺⣗⣷⣻⣞⣷");
            Console.WriteLine("⣯⣟⣷⣻⣞⣷⡳⡀⠄⠠⠀⠂⢀⠐⠈⠀⠄⠐⠈⢀⠐⠈⡀⠄⠠⠡⢸⢪⢯⡣⣫⢮⠢⠡⢂⠐⡐⡑⠓⡊⠫⢊⠊⠜⠨⢘⠠⠀⠂⢀⠐⠈⠀⠄⠐⠈⠠⠀⠂⢀⢑⢑⠓⠱⢊⠓⢸⣳⣟⣾⣳⣟⣞");
            Console.WriteLine("⣗⣿⣺⣳⣻⣞⣯⣝⣜⣕⣕⣵⢕⣭⣢⣇⢷⣍⣮⣪⣪⣺⣜⣜⣕⣭⣪⡯⣟⣞⣗⣯⣪⣣⣣⣣⣳⣜⣕⣕⣭⡪⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⢀⠠⠐⠀⠠⢰⣍⣇⣧⣹⢼⣗⣿⣺⣗⣿⣺");
            Console.WriteLine("⢷⣻⢾⣽⣳⣟⣾⣳⣟⣾⢽⣞⣯⣷⣻⣞⣯⡷⣷⣻⣞⣷⣻⣞⣷⣻⣞⣯⣟⣷⣻⣞⡷⣯⢷⣯⢷⣻⣞⡷⣯⢯⠈⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⠠⢁⢸⣞⣷⣻⣞⣿⣺⣗⣿⣺⣞⣷");
            Console.WriteLine("⢿⣽⣻⣞⣷⣻⣞⣷⣻⣞⣯⢿⣺⣞⣷⣻⢾⡽⣗⣿⣺⣗⣿⣺⣗⣟⣾⣳⣟⣾⣳⢯⡿⣽⣻⣞⣯⡷⣯⢿⣽⣳⢨⠰⡨⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⠀⢸⣞⣷⣻⣞⣷⣻⣞⣷⣻⣞⣷");
            Console.WriteLine("⣻⣞⣷⣻⣞⣷⣻⣞⣾⣳⢿⣽⣻⣞⣷⣻⡽⣯⢿⣺⣗⣿⣺⣳⣟⣾⣳⣟⡾⣾⢽⡯⣟⣷⣻⣞⣷⣻⣽⣻⣞⣷⣳⣟⡾⣞⡯⢐⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⠀⠠⣳⣟⣾⣳⢷⣻⣞⣷⣻⢾");
            Console.WriteLine("⣷⣻⣺⣳⢷⢷⣗⣿⣺⣽⡻⣞⣷⣻⣞⣷⣻⡽⣯⢷⣻⣞⣷⣻⣞⣷⣻⢾⡽⣯⡯⣿⢽⣞⣷⣻⣞⣷⣻⣞⣷⣻⣞⣷⣻⢯⣗⠀⠂⠁⡀⠂⠁⢈⠀⠠⠈⢀⠠⠐⡈⢸⣞⣷⣻⢾⡽⣯⢷⣻⢾⣺⡯");
            Console.WriteLine("⣻⢾⣽⢽⣻⣽⣞⣷⣻⢾⡽⣽⣺⣳⣳⢽⣞⡯⡿⣽⣗⣿⣺⣗⣿⣺⡽⣯⣟⣷⣻⡽⣯⢷⣻⣞⣷⣳⣟⡾⣞⣷⣻⣺⣽⣻⣞⣬⣣⠁⠂⠁⠠GOAL⠂⠁⠐⣕⡵⣟⣾⢽⡯⣯⢿⡽⣯⣟⣷⣻");
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.Write("🧙🏻‍");

            Console.SetCursorPosition(MonsterX, MonsterY);
            Console.Write("🧌");

            Console.SetCursorPosition(0, MaxY + 2);
            Console.WriteLine("방향키로 이동하세요. 몬스터에 닿으면 전투를 시작합니다!");


        }
    }
    
    
}
