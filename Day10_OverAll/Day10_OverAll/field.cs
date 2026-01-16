using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10_OverAll
{
    public class Field
    {
        Player m_pPlayer;
        Monster m_pMonster;

        public void SetPlayer(Player pPlayer) {  m_pPlayer = pPlayer; }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();

                //맵
                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                {
                    break;
                }

                if (iInput <=3)
                {
                    //몬스터 만들고
                    //1층 - 초보 몬스터
                    //2층 - 중급 몬스터
                    //3층 - 고급 몬스터
                    CreateMonster(iInput);
                    //싸우고
                    Fight();
                }
            }
        }

        //생성을 도와주는 함수
        //공장like 찍어내기
        //팩토리 메서드 패턴
        public void Create(string strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();   //몬스터 생성
            Info tMonster = new Info();     //몬스터 데이터 메모리 주기 객체 생성

            tMonster.strName = strName;     //몬스터 초,중,고
            tMonster.iHp = _iHp;            //몬스터 체력
            tMonster.iAttack = _iAttack;    //공격력

            pMonster.SetMonster(tMonster);  //생성된 데이터 Info 클래스타입 데이터 사용

        }


        public void CreateMonster(int input)    //몬스터 만들기
        {
            switch(input)
            {
                case 1:
                    //공장처럼 찍어내 줌.
                    //디자인 패턴 -> 팩토리 메서드 패턴(검색해서 알아봐라)
                    Create("슬라임", 30, 3,out m_pMonster);
                    break;
                case 2:
                    
                    Create("고블린", 60, 7, out m_pMonster);
                    break;
                case 3:
                    
                    Create("오거", 100, 15, out m_pMonster);
                    break;
            }
        }

        public void Fight()     //전투 함수
        {
            int iInput = 0;
            const int Heal = 20;
            const int Max_HP = 100;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격  2.도망  3.회복  :");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if(m_pPlayer.GetInfo().iHp <=0 )
                    {
                        m_pPlayer.SetHp(100);

                        Console.WriteLine("당신은 죽었습니다.");
                        Thread.Sleep(1000);
                        break;
                    }
                }

                if(iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null; //참조일때 null 초기화하면 가비지컬렉터에서 나중에 알아서 메모리 삭제
                    break;
                }

                if(iInput == 3)
                {
                    int currentHp = m_pPlayer.GetInfo().iHp;
                    int newHp = currentHp + Heal;
                    if (newHp > Max_HP) newHp = Max_HP;

                    m_pPlayer.SetHp(newHp);
                    Console.WriteLine("체력을 회복하였습니다.");
                    Thread.Sleep(500);
                }
            }

        }

        public void DrawMap()
        {
            Console.WriteLine("1. 지하 1층");
            Console.WriteLine("2. 지하 2층");
            Console.WriteLine("3. 지하 3층");
            Console.WriteLine("4. 이전 단계");
            Console.WriteLine("===========");
            Console.WriteLine("던전 층을 선택하세요: ");
        }
    }
}
