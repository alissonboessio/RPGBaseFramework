using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Lost : Scene
    {
        public Lost()
        {
            World.addPlace(new List<string>
            {
                "Como estava escuro voce se perdeu e chegou ao labirinto...",
                " ",
"================================================.",
"                                                |",
"                                                |",
"                                                |",
"                                                |",
"===============.       .================.       |",
"               |       |                |       |",
"               |       |                |       |",
"               |       |                |       |",
"               |       |                |       |",
"==============='       '================'       |",
"------------------------------------------     -."
            });

            World.addOptions(new List<string>
            {
                "1) Encontrar a saida",
                "2) Esperar o tempo passar"
            });
        }

        public override Scene Options(string option)
        {
            if (option == "2")
            {
                return new Dragon();
            }
            return new Ending();
        }
    }

    
}
