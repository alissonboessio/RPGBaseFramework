using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Menu : Scene
    {
        public Menu()
        {

            World.addOptions(new List<string>
                            {
                                "1) Jogar",
                                "2) Sair"
                            });
        

    }
        public override Scene Options(string option)
        {
            if(option != "1")
            {
                Environment.Exit(0);
            }

            return new PlayerCreate();

        }

    }
}
