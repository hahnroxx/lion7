using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_property_assign
{
    class Student
    {
        private string name;
        private int score;
        private string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
            set
            {
                if (value > 100)
                    score = 100;
                else if (value < 0)
                    score = 0;
                else
                    score = value;
            }
        }
        public char Grade
        {
            get 
            {
                if (score <= 100 && score > 90)
                    return 'A';
                else if (score <= 90 && score > 80)
                    return 'B';
                else if (score <= 80 && score > 70)
                    return 'C';
                else if (score <= 70 && score > 60)
                    return 'D';
                else
                    return 'F';
            }
            
                
            
        }

        public Student(string StudentName)
        {
            name = StudentName;
        }

        //정보 출력
        public void ShowStudentInfo()
        {
            Console.WriteLine($"====== 학생 정보 ======");
            Console.WriteLine($"학생 이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"학점: {Grade}");
            Console.WriteLine($"=====================");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("김한");

                student.Score = 95;
                student.ShowStudentInfo();

                Console.WriteLine();

            Student student2 = new Student("홍승아");
                student2.Score = 75;
                student2.ShowStudentInfo();

                Console.WriteLine();

                //// 잘못된 값 입력 시도
                //student.Score = 150;  // 100으로 제한되어야 함
                //student.Score = -10;  // 0으로 제한되어야 함
                //student.ShowStudentInfo();
            }
    }
}
