using RPGBaseFramework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPGBaseFramework.Base
{
    //TODO show success or failure for attacks and defenses
    internal abstract class BattleScene : Scene
    {
        public Scene Previous;

        public BattleScene()
        {
            World = new World(25, 80);
            World.Fill();

            Camera = new Camera();
        }

        public string RequestUserOption()
        {
            Console.Write("O que voce faz? ");
            return Console.ReadLine();

        }

        public EnumBattle Battle(string option)
        {
            Player p = State.GetPlayer();
            Opponent o = State.GetOpponent();
            Random random = new Random();

            int.TryParse(option, out int optionAux);

            Attack chosenAttack = p.GetAttack(optionAux);
            Attack oponentChosenAttack = o.GetAttack(random.Next(1, o.AttackList.Count()));

            if(chosenAttack != null && oponentChosenAttack!= null && !oponentChosenAttack.isADefense())
            {
                int hit = random.Next(1, chosenAttack.getHitChanceWeight() + 1);

                if (chosenAttack.getHitChanceWeight() == hit)
                {
                    o.Life -= chosenAttack.getStrength();
                }           

                if(o.Life <= 0)
                {
                    o = null;
                    return EnumBattle.Won;
                }

            }

            if(oponentChosenAttack != null && chosenAttack != null && !chosenAttack.isADefense())
            {
                int hit = random.Next(1, oponentChosenAttack.getHitChanceWeight() + 1);

                if (oponentChosenAttack.getHitChanceWeight() == hit)
                {
                    p.Life -= oponentChosenAttack.getStrength();
                }

                if(p.Life <= 0)
                {
                    return EnumBattle.Loose;
                }

            }

            return EnumBattle.Wait;
            
        }

        public void Show()
            {
                Camera.Draw(World);
            }

        }
}
