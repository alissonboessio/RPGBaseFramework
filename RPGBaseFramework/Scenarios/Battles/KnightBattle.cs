using RPGBaseFramework.Base;
using RPGBaseFramework.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Scenarios.Battles
{
    internal class KnightBattle : BattleScene
    {
        Player p = State.GetPlayer();
        Opponent o = State.GetOpponent();
        protected EnumBattle battleStatus;

        public KnightBattle()
        {
            battleStatus = EnumBattle.Wait;
            writeOptions();
        }

        public void writeOptions()
        {
            World.addPlace(new List<string>
            {
                "Voce esta em batalha!!",
                $"Sua vida: {p.Life} ",
                $"Vida do(a) {o.Name}: {o.Life}"
            });

            World.addOptions(p.getListAttacks());
        }

        public override Scene Options(string option)
        {

            switch (battleStatus)
            {
                case EnumBattle.Wait:
                    battleStatus = Battle(option);
                    break;
                case EnumBattle.Won:
                    var won = new WonBattle();
                    won.Next = new Lost();

                    return won;
                    break;
                case EnumBattle.Loose:
                    return new BadEnding(new List<string> { 
                        "Voce foi derrotado!"
                    });

                    break;
                case EnumBattle.Ran:
                    break;
                default:
                    break;
            }

            if (battleStatus == EnumBattle.Won || battleStatus == EnumBattle.Loose)
            {
               return this.Options("");
            }                
            
            writeOptions();

            return this;

        }
    }
}
