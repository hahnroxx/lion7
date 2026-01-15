using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 슈팅게임만들기
{
    //미사일 클래스
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //C언어 함수 가져옴

        public int playerX;
        public int playerY;

        public Bullet[] playerBullet = new Bullet[20];   //미사일 20개 생성 후 준비된 미사일 활용
        public Bullet[] playerBullet2 = new Bullet[20];
        public Bullet[] playerBullet3 = new Bullet[20];
        public int Score = 100;

        //아이템
        public Item item = new Item();
        public int ItemCount = 0;

        public Player()     //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)    //총알 20개 초기화
            {
                playerBullet[i] = new Bullet(); //객체 생성
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new Bullet(); //객체 생성2
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new Bullet(); //객체 생성3
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }

        public void GameMain()
        {
            KeyControl();   //키 입력하는 부분 
            PlayerDraw();   //플레이어를 그려준다
            UIscore();      //Ui 점수

            if(item.ItemLife)
            {
                item.ItemDraw();
                //아이템 충돌 시
                CrashItem();
            }
        }

        public void CrashItem()
        {
            if(playerY +1 == item.itemY)
            {
                if(playerX >= item.itemX -2 && playerX <= item.itemX +2)
                {
                    item.ItemLife = false;

                    if (ItemCount < 3)
                        ItemCount++;
                    for(int i = 0; i < 20; i++)
                    {
                        playerBullet[i] = new Bullet(); //객체 생성
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new Bullet(); //객체 생성2
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new Bullet(); //객체 생성3
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }


        public void KeyControl()
        {
            int pressKey;   //정수형 변수 선언. 키값 받기

            if (Console.KeyAvailable)   //키가 눌렸을 때
            {
                pressKey = _getch();    //아스키값 왼쪽 오른쪽 등

                if (pressKey == 224) pressKey = _getch();

                switch (pressKey)
                {
                    case 72:    //위쪽 방향 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:    //왼쪽 화살표
                        playerX--;
                        if (playerX < 1)
                            playerX = 1;
                        break;
                    case 77:    //오른쪽 화살표
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80:    //아래쪽 화살표
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32:    //스페이스바 - 총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false인 애들 발사 가능
                            if (playerBullet[i].fire == false)
                            {
                                //쏠 수 있는 상태로 만들어주고
                                playerBullet[i].fire = true;

                                //비행기 머리에서 쏠 수 있게
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)        //총알 2 발사
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)        //총알 3 발사
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }

        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "=*";

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.Write(bullet);      //총알 출력
                    playerBullet[i].x++;    //미사일 x축 방향으로 날아가게

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;   //미사일 x축 끝에 닿으면 다시 쏠 수 있게
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            
            string bullet2 = ">*";
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    Console.Write(bullet2);      //총알 출력
                    playerBullet2[i].x++;    //미사일 x축 방향으로 날아가게

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;   //미사일 x축 끝에 닿으면 다시 쏠 수 있게
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            
            
            string bullet3 = "-*";

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    Console.Write(bullet3);      //총알 출력
                    playerBullet3[i].x++;    //미사일 x축 방향으로 날아가게

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;   //미사일 x축 끝에 닿으면 다시 쏠 수 있게
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            string[] player = new string[]  //배열로 플레이어 그린다.
            {
                "-*",
                "=+>",
                "-*"
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //-------------------------일단 여기까지 플레이어 완성-----------------------------

        //충돌처리 -> 적 클래스도 구현해야 함.
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if(playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX -1) 
                            && playerBullet[i].x <= (enemy.enemyX + 1))  //충돌시의 영역
                        {
                            //아이템 충돌
                            if(item.ItemLife == false)
                            {
                                item.ItemLife = true;
                                item.itemX = enemy.enemyX;
                                item.itemY = enemy.enemyY;
                            }
                            

                        
                            //충돌 후에는?
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;   //미사일도 다시 준비 상태로

                            //스코어도 올라가야지
                            Score += 100;
                        }
                    }
                }
            }
            //미사일2 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;

                        }
                    }

                }
            }


            //미사일3 20
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; //미사일도 준비상태로 만들어주기

                            //스코어
                            Score += 100;

                        }
                    }

                }
            }
        
    
}

    }

    //적 클래스
    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw() //적 긔리기
        {
            string enemy = "<-0->";     //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY);
            Console.WriteLine(enemy);   //출력
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;  //왼쪽으로 움직임

            if (enemyX < 2)     //화면 왼쪽 넘어가면 새로 좌표 잡기
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);      //2~21 사이에서 새로 생성
            }
        }


    }

    //아이템 클래스
    //적이 죽으면 아이템이 나오고, 먹으면 미사일 업글
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //플레이어 생성
            Player player = new Player();
            //적 생성
            Enemy enemy = new Enemy(); 

            //콘솔 속도 만들기 frame 60dps
            int dwTime = Environment.TickCount; // 1000분의 1초가 흐른다

            while(true)     //무한 반복
            {
                //o.o5초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();        //0.05초 마다 싹 지워줌

                    //플레이어
                    player.GameMain();
                    //총알 그리기
                    if (player.ItemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.ItemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                        //적 생성
                        enemy.EnemyDraw();
                    enemy.EnemyMove();

                    player.ClashEnemyAndBullet(enemy);
                }
            }

        }
    }
}
