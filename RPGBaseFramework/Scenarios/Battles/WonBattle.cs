using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios.Battles
{
    internal class WonBattle : Scene
    {
        public Scene Next;

        public WonBattle()
        {
            World.addPlace(new List<string>
            {
                "Parabens voce venceu a batalha!"

            });

            World.addOptions(new List<string>
            {
                "Pressione Enter para continuar"
            });
        }

        public override Scene Options(string option)
        {
            return Next;
        }

    }
}
