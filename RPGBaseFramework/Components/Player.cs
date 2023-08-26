using RPGBaseFramework.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Components
{
    internal class Player
    {
        public string Name;
        public int Life = 100;

        public string Bag = "vazio";

        public List<Attack> AttackList = new List<Attack>();

        public List<string> getListAttacks()
        {
            List<string> list = new List<string>();

            foreach (Attack attack in AttackList)
            {
                list.Add(attack.attackFormatted());
            }

            return list;
        }

        public Attack? GetAttack(int option)
        {
            foreach (Attack attack in AttackList)
            {
                if (attack.getOptionNumber() == option)
                {
                    return attack;
                }
            }
            return null;
        }
    }
}
