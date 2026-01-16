using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_OverAll
{
    public class Player
    {
        public Info m_tInfo;

        //데미지를 입는 함수
        public void SetDamage(int iAttack)
        { m_tInfo.iHp -= iAttack; }

        //플레이어 정보를 외부에서 볼 수 있는 함수
        public Info GetInfo()
        { return m_tInfo;}

        //hp를 다시 설정하는 함수
        public void SetHp(int iHp)
        { m_tInfo.iHp = iHp;}

        public void SelectJob()
        {
            m_tInfo = new Info();

            Console.WriteLine("직업을 선택하세요(1.기사, 2.마법사, 3.도적) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHp = 50;
                    m_tInfo.iAttack = 20;
                    break;
                case 3:
                    m_tInfo.strName = "도적";
                    m_tInfo.iHp = 40;
                    m_tInfo.iAttack = 25;
                    break;

            }
        }

        public void Render()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("직업: " + m_tInfo.strName);
            Console.WriteLine($"체력: {m_tInfo.iHp} \t공격력: {m_tInfo.iAttack}");
            Console.WriteLine("=======================");

        }

        public Player() { } //생성자

        ~Player() { }       //소멸자
    }
}
