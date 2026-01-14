using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_this
{
    class Skill
    {
        //필드 변수
        private string name;
        private int att;

        public Skill()
        {

        }

        public Skill(string name, int att)
        {
            //name = name;  <----- 이렇게 하면 컴이 헷갈려함
            this.name = name; //<----- 그래서 this를 붙여서 내꺼야! 이렇게 해줌
            this.att = att;
        }

        public void SkillStart()
        {
            Console.WriteLine("스킬명: " + this.name);
            Console.WriteLine("스킬 데미지: " + att);
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Skill s = new Skill("메테오", 100000000);
            s.SkillStart();
        }
    }
}
