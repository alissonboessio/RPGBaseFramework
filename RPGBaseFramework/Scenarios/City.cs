using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class City : Scene
    {
        public City()
        {

            World.addPlace(new List<string>
            {
                "Voce sente que algo ou alguem esta te observando...",
                " ",
                "         █▄██▄█",
                "█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█",
                "███┼█████▐████▌█████┼███",
                "█████████▐████▌█████████"
            });

            World.addOptions(new List<string>
            {
                "1) Entrar pelo portao principal",
                "2) Procurar outra entrada"
            });
        }

        public override Scene Options(string option)
        {
            if(option == "2")
            {
                return new Aliens();
            }
            return new Castle();
            //throw new NotImplementedException();
        }

    }
}
