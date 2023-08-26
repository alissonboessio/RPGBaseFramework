using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class List : Scene
    {

        public string[] Items;

        public List(string[] items)
        {
            Items = items;

            List<string> lista = new List<string>
            {
                "█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█"
            };

            int n = 1;

            foreach (var item in items)
            {
                lista.Add($"█{n++} --> {item}".PadRight(20, ' ') + " █");
            }

            lista.Add("█--------------------█");
            lista.Add("█0 --> Sair          █");
            lista.Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

            World.addPlace(lista);

            World.addOptions(new List<string>
            {
                "Qual voce compra?"
            });

        }
        public override Scene Options(string option)
        {
            Environment.Exit(0);

            throw new NotImplementedException();
        }
    }
}
