using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day4_sword_inhence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //내가만든 문제 
            //검키우기 만들기 
            //검은 종류는 5개 
            //1.꽃다발 2.나무몽둥이 3.철검 4.광선검 5.무형검
            //2. 스펙 각 강화에 따른 공격력을 지님 
            //3. 강화확률 모두동일 25퍼확률 파괴 25퍼확률 유지 50퍼확률성공 
            //4. 최대 강화 15강 
            //5. 강화에 필요한 골드 100골드 
            //6. 보유골드 100000골드 
            //7. 파괴 시 랜덤 무기 지급 
            Random random = new Random();
            int randomRullet = 0;
            string sword = "";
            string yN;
            int rank = 0;
            int percent = 0;
            string word = "";
            string word2 = "";
            bool isBroken = false;

            Console.WriteLine("=검키우기=");
            randomRullet = random.Next(1, 6);
            for (; ; )
            {
                Console.WriteLine($"무기를 지급받으시겠습니까? (Y,N)");
                yN = Console.ReadLine();
                if (yN == "y" || yN == "Y")
                {
                    Console.WriteLine("그럼 무기를 지급해드리겠습니다.");
                    break;
                }
                else if (yN == "n" || yN == "N")
                {
                    Console.WriteLine("당신에게 그런 권한은없습니다.");
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                }
            }
            switch (randomRullet)
            {
                case 1:
                    sword = "꽃다발";
                    break;
                case 2:
                    sword = "나무몽둥이";
                    break;
                case 3:
                    sword = "철검";
                    break;
                case 4:
                    sword = "광선검";
                    break;
                case 5:
                    sword = "무형검";
                    break;
                default:
                    Console.WriteLine("유효하지않은무기");
                    break;
            }
            Console.WriteLine("지금부터 무기를 강화해봅시다.");
            Console.WriteLine($"현재 당신의 무기는 {sword} (+{rank})강 입니다");
            Console.WriteLine($"강화를 시도하시겠습니까?  (Y,N)");
            for (; ; )
            {
                for (; ; )
                {
                    yN = Console.ReadLine();
                    if (yN == "y" || yN == "Y")
                    {
                        Console.WriteLine("강화를 시도합니다!");
                        break;
                    }
                    else if (yN == "n" || yN == "N")
                    {
                        Console.WriteLine("당신에게 그런 권한은없습니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못입력하셨습니다.");
                    }
                }


                Console.WriteLine("강화중.");
                Thread.Sleep(500);
                Console.WriteLine("강화중..");
                Thread.Sleep(500);
                Console.WriteLine("강화중...");
                Thread.Sleep(500);
                Console.WriteLine("강화중....");
                Thread.Sleep(500);
                Console.WriteLine("강화중.....");
                Thread.Sleep(500);
                percent = random.Next(1, 5);
                switch (percent)
                {
                    case 1:
                    case 2:
                        rank++;
                        word = $"강화성공 +{sword}{rank}강";
                        break;
                    case 3:
                        rank = 0;
                        word = $"파괴.. 어잌후 손이 미끌어졌네?";
                        isBroken = true;
                        switch (randomRullet)
                        {
                            case 1:
                                sword = "꽃다발";
                                break;
                            case 2:
                                sword = "나무몽둥이";
                                break;
                            case 3:
                                sword = "철검";
                                break;
                            case 4:
                                sword = "광선검";
                                break;
                            case 5:
                                sword = "무형검";
                                break;
                            default:
                                Console.WriteLine("유효하지않은무기");
                                break;
                        }

                        break;
                    case 4:
                        word = "강화유지 운이.. 좋은건가?";
                        break;
                }
                Console.WriteLine(word);
                if (isBroken)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"미안하니 이거라도 가져가게..{sword}를 지급 받았다.");
                }

                isBroken = false;
                Console.WriteLine($"강화를 시도하시겠습니까?  (Y,N)");

            }



        }








        static void Mai(string[] args)
        {
            //내가만든 문제 
            //검키우기 만들기 
            //검은 종류는 5개 
            //1.꽃다발 2.나무몽둥이 3.철검 4.광선검 5.무형검
            //2. 스펙 각 강화에 따른 공격력을 지님 
            //3. 강화확률 모두동일 25퍼확률 파괴 25퍼확률 유지 50퍼확률성공 
            //4. 최대 강화 15강 
            //5. 강화에 필요한 골드 100골드 
            //6. 보유골드 10000골드 
            //7. 파괴 시 랜덤 무기 지급 
            Random random = new Random();
            int randomRullet = 0;
            string sword = "";
            string yN;
            int rank = 0;
            int percent = 0;
            string word = "";
            string word2 = "";
            bool isBroken = false;
            int startGold = 10000;
            int consumGold = 100;
            Console.WriteLine("=검키우기=");
            randomRullet = random.Next(1, 6);
            for (; ; )
            {
                Console.WriteLine($"무기를 지급받으시겠습니까? (Y,N)");
                yN = Console.ReadLine();
                if (yN == "y" || yN == "Y")
                {
                    Console.WriteLine("그럼 무기를 지급해드리겠습니다.");
                    break;
                }
                else if (yN == "n" || yN == "N")
                {
                    Console.WriteLine("당신에게 그런 권한은없습니다.");
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                }
            }
            switch (randomRullet)
            {
                case 1:
                    sword = "꽃다발";
                    break;
                case 2:
                    sword = "나무몽둥이";
                    break;
                case 3:
                    sword = "철검";
                    break;
                case 4:
                    sword = "광선검";
                    break;
                case 5:
                    sword = "무형검";
                    break;
                default:
                    Console.WriteLine("유효하지않은무기");
                    break;
            }
            Console.WriteLine("지금부터 무기를 강화해봅시다.");
            Console.WriteLine($"현재 당신의 무기는 {sword} (+{rank})강 입니다");
            Console.WriteLine($"강화비용은 {consumGold} 입니다");
            Console.WriteLine($"강화를 시도하시겠습니까?  (Y,N)");
            for (; ; )
            {
                for (; ; )
                {
                    yN = Console.ReadLine();
                    if (yN == "y" || yN == "Y")
                    {
                        Console.WriteLine("강화를 시도합니다!");
                        break;
                    }
                    else if (yN == "n" || yN == "N")
                    {
                        Console.WriteLine("당신에게 그런 권한은없습니다.");
                    }
                    else
                    {
                        Console.WriteLine("잘못입력하셨습니다.");
                    }
                }

                startGold -= 100;
                Console.WriteLine("강화중.");
                Thread.Sleep(500);
                Console.WriteLine("강화중..");
                Thread.Sleep(500);
                Console.WriteLine("강화중...");
                Thread.Sleep(500);
                Console.WriteLine("강화중....");
                Thread.Sleep(500);
                Console.WriteLine("강화중.....");
                Thread.Sleep(500);
                percent = random.Next(1, 5);
                switch (percent)
                {
                    case 1:
                    case 2:
                        rank++;
                        word = $"강화성공 +{sword}{rank}강";
                        break;
                    case 3:
                        rank = 0;
                        word = $"파괴.. 어잌후 손이 미끌어졌네?";
                        isBroken = true;
                        switch (randomRullet)
                        {
                            case 1:
                                sword = "꽃다발";
                                break;
                            case 2:
                                sword = "나무몽둥이";
                                break;
                            case 3:
                                sword = "철검";
                                break;
                            case 4:
                                sword = "광선검";
                                break;
                            case 5:
                                sword = "무형검";
                                break;
                            default:
                                Console.WriteLine("유효하지않은무기");
                                break;
                        }

                        break;
                    case 4:
                        word = "강화유지 운이.. 좋은건가?";
                        break;
                }
                Console.WriteLine(word);
                if (isBroken)
                {
                    Thread.Sleep(500);
                    Console.WriteLine($"미안하니 이거라도 가져가게..{sword}을(를) 지급 받았다.");
                }

                isBroken = false;

                if (rank > 14)
                {
                    Console.WriteLine("클리어하셨습니다 운좋은사람.. 당신의 승리");
                }
                else
                {
                    Console.WriteLine($"남은 골드는 : {startGold}G 입니다");
                    Console.WriteLine($"강화를 시도하시겠습니까?  (Y,N)");
                }

            }



        }
    }
}
