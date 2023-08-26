using RPGBaseFramework.Base;
using RPGBaseFramework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class PlayerCreate : Scene
    {

        public PlayerCreate()
        {
            World.addPlace(new List<string>
            {
                " ### Criacao do Personagem ### ",
                " ",
                " Informe o nome!"
            });
        }

        public override Scene Options(string option)
        {
            Player p = State.GetPlayer();
            p.Name = option;
            //TODO ask the user the attacks he wants

            p.AttackList.Add(new Attack(1, "Chute", 20, 3));
            p.AttackList.Add(new Attack(2, "Soco", 10, 2));
            p.AttackList.Add(new Attack(3, "Defender", 0, 1, true));
            p.AttackList.Add(new Attack(4, "Chute + Soco", 40, 10));

            return new City();
        }
    }
}
