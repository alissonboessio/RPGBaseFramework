using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Ending : Scene
    {
        public Ending()
        {
            World.addPlace(new List<string>
            {
                "Ao chegar a saida do labirinto voce acorda e",
                "Percebe que tudo nao passou de um pesadelo...",
                " ",
"       ||",
"       ||                   ||",
"    ||/||___                ||",
"    || /`   )____________||_/|",
"    ||/___ //_/_/_/_/_/_/||/ |",
"    ||(___)/_/_/_/_/_/_/_||  |",
"    ||     |_|_|_|_|_|_|_|| /|",
"    ||     | | | | | | | ||/||",
"    ||~~~~~~~~~~~~~~~~~~~||   ",
"    ||                   ||   "
            });

            World.addOptions(new List<string>
            {
                "1) Levantar da cama",
                "2) Sair do jogo"
            });
        }

        public override Scene Options(string option)
        {
            if (option == "2")
            {
                Environment.Exit(0);
            }
            return new City();
        }
    }

    
}
