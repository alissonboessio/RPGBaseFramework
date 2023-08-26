using RPGBaseFramework.Base;
using RPGBaseFramework.Components;
using RPGBaseFramework.Scenarios.Battles;

namespace RPGBaseFramework.Scenarios
{
    internal class Knight : Scene
    {

        public Knight()
        {
            World.addPlace(new List<string>
            {
                "Voce se depara com uma armadura...",
                " ",
"                 !",
"                .-.",
"              __|=|__",
"             (_/`-`\\_)",
"             //\\___/\\\\",
"             <>/   \\<>",
"              \\|_._|/",
"               <_I_>",
"                |||",
"               /_|_\\"
            });

            World.addOptions(new List<string>
            {
                "1) Chegar mais perto e batalhar",
                "2) Fugir"
            });
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return EnterBattle();                   

            }
            return new Lost();
        }

        public BattleScene EnterBattle()
        {
            Opponent opponent = State.GetOpponent();
            opponent.Name = "Armadura";
            opponent.Life = 50;
            opponent.AttackList = new List<Attack>
            {
                new Attack(1, "Espadada", 15, 4),
                new Attack(2, "Empurrao", 5, 3),
                new Attack(3, "Defender", 0, 1, true)
            };

            var newBattle = new KnightBattle();
            newBattle.Previous = this;

            return newBattle;
        }

    }
}
