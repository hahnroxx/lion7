using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_DungeonBob
{
    internal class GameState
    {
        public int RawMonster = 0;

        public Dictionary<string, int> Ingred = new Dictionary<string, int>(); 

        public void AddIngred(string name, int count = 1)
        {
            if (!Ingred.ContainsKey(name)) Ingred[name] = 0;
            Ingred[name] += count;
        }

        public bool HasIngred(string name, int count = 1)
        {
            return Ingred.ContainsKey(name) && Ingred[name] >= count;
        }

        public bool UseIngred(string name, int count = 1)
        {
            if (!HasIngred(name, count)) return false;

            Ingred[name] -= count;
            if (Ingred[name] <= 0) Ingred.Remove(name);
            return true;
        }

        public int PlayerHp = 100;
        public int PlayerMaxHp = 100;
    }
}
