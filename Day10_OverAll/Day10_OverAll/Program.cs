using Day10_OverAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_TextRPG
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //텍스트RPG
            MainGame mainGame = new MainGame();

            mainGame.Initialize();
            mainGame.Progress();
        }
    }
}
