using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Aliens : Scene
    {
        public Aliens()
        {

            World.addPlace(new List<string>
            {
                "              ▄▀█▀█▀▄",
                "             ▀▀▀▀▀▀▀▀▀", 
                "             ▄ |||||▄",
                "   █  ▄ ▄   ▐▌▌|||||▌▌",
                "▌▄█▐▌▐█▐▐▌█▌█▌█|||||▌▌"
            });

            World.addOptions(new List<string>
            {
                "Voce foi encontrado por alienigenas e foi abduzido... FIM"
            });
        }

        public override Scene Options(string option)
        {
            Environment.Exit(0);

            throw new NotImplementedException();
        }

    }
}
