using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_OverAll
{
    public class MainGame
    {
        public Player m_pPlayer = null;
        public Field m_pField = null;


        //초기화 함수
        public void Initialize()
        {
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
        }

        //게임 전체 과정 관리. seltecJob 끝나면 이 함수로 올 수 있게
        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();  //플레이어 출력
                Console.WriteLine("1. 던전   2. 종료 : ");
                iInput = int.Parse(Console.ReadLine());

                switch (iInput)
                {
                    case 1:      //사냥터 구현
                        if(m_pField == null)
                        {
                            m_pField = new Field();
                            m_pField.SetPlayer(m_pPlayer);
                        }
                        m_pField.Progress();
                        break;
                    case 2:      //종료
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
