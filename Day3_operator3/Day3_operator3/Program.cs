using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //비트 연산자
            //글자 하나가 1비트임! 그렇게 치면
            
            int x = 5;  // 글자 4바이트 숫자 5는 0101 
            int y = 3; // 0011

            Console.WriteLine(x & y); //이러면 비트의 이진법 숫자식으로 계산해서 출력됨
            // 숫자 5는 0101 곱하기 0011 => 자릿수끼리 곱해지기 때문에
            //  0001이 되는 거겠지? 0001은 십진법 숫자 1이니까 1로 출력됨
            Console.WriteLine(y | x); //이건 비트단위 더하기니까 0111
            Console.WriteLine(x ^ y);   //이걸 XOR(엑스오어)이라고 한다.
            //비트단위 더하기인데, 1+1=0인 더하기라고 생각하면 된다.
            //자릿수마다 같은 애면 0, 다른 애면 1로 잡는다고 생각하면 됨.
            

            int value = 4; //0100
            string binary = Convert.ToString(value,2);
            // << >>
            Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}");
            binary = Convert.ToString(value >> 1, 2);
            // << >>
            Console.WriteLine ($"8비트: {binary.PadLeft(8,'0')}");

            int inventory = 0; // 0000 0000

            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");








        }
    }
}
