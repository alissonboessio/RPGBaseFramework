using RPGBaseFramework.Base;
using RPGBaseFramework.Components;
using RPGBaseFramework.Scenarios.Battles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Dragon : Scene
    {
        public Dragon()
        {
            World.addPlace(new List<string>
            {
                "Voce adormece e quando acorda",
                "percebe que na verdade nao era um labirinto...",
                " ",
"                       .     _///_,",
"                     .      / ` ' '>",
"                       )   o'  __/_' >",
"                      (   / _ /  )_\'>",
"                       ' '__/   /_/\\_>",
"                           ____ / _ / _ / _ /",
"                          /,---, _ / /",
"                         '' / _ / _ / _ /",
"                            / _(_(_(_                 \\",
"                           (   \\_\\_\\\\_)\\",
"                            \'__\\_\\_\\_\\__            ).\\",
"                            //____|___\\__)           )_/",
"                            | _  \\'___'_(           / '",
"                             \\_(-'\\'___'_\\      __, '_'",
"                             __) \\  \\\\___(_   __ /.__, '",
"                          ,((,-,__\\  '', __\\_/. __,'",
"                                       ''./_._._-'"
            });

            World.addOptions(new List<string>
            {
                "1) Ficar e lutar",
                "2) Fugir",

            });
        }

        public override Scene Options(string option)
        {

            if (option == "1")
            {
                return EnterBattle();

            }
            else
            {
                return new BadEnding(new List<string>
                {
                    "Voce tenta fugir, mas o dragão é muito rápido... FIM"
                });
            }
        }

        public BattleScene EnterBattle()
        {
            Opponent opponent = State.GetOpponent();
            opponent.Name = "Dragao";
            opponent.Life = 500;
            opponent.AttackList = new List<Attack>
                {
                    new Attack(1, "Bola de fogo", 30, 4),
                    new Attack(2, "Garra", 20, 3),
                    new Attack(3, "Rasante", 10, 2)
                };

            var newBattle = new DragonBattle();
            newBattle.Previous = this;

            return newBattle;
        }
    }
}
