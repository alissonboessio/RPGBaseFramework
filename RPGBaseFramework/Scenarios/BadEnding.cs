using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class BadEnding : Scene
    {
        public BadEnding(List<string> message)
        {
            World.addPlace(message);

            World.addOptions(new List<string>
            {
                "Pressione Enter para continuar"
            });
        }

        public override Scene Options(string option)
        {            
            Environment.Exit(0);
            return null;
        }
    }
}
