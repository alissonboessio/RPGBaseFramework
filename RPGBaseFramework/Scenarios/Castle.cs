using RPGBaseFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            World.addPlace(new List<string>
            {
                "O castelo esta iluminado por velas...",
                "Voce escuta um som metalico, como se algo caisse no chao...",
                " ",                                 
"            )\\        ,          /(|       (          ,",
"   (       /  )        (\\       (  \\       ) )       ((",
"   )\\     (   (        ) )      ) , )     / (        ) \\",
"  /  )     ) . )      /  (     ( # (     ( , )      /   )",
" ( * (      \\#/      (`# )      `#/|      `#/      (  '(",
"  \\#/     .-'#'-.   .-'#'-,   .-'#'-.   .-=#'-;     `#/",
".-'#'-.   |'=,-'|   |'-.-'|)  1'-.-'|   |'-.-'|   ,-'#'-.",
"|'-.-'|   |  !  |   |     |   |     |   |     |   |'-.-'|",
"|     |   |     |._,|     |   |     |._,|     |   |     |",
"'-._,-'   '-._,-'   '-._,-'   '-._,-'   '-._,-    '-._,-'"
            });

            World.addOptions(new List<string>
            {
                "1) Correr em direcao ao barulho",
                "2) Tentar se esconder"
            });
        }

        public override Scene Options(string option)
        {
            if (option == "2")
            {
                return new Lost();
            }
            return new Knight();
        }
    }
}
