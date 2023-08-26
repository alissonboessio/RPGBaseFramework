using RPGBaseFramework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework
{
    internal class State
    {
        private static Player playerInstance;
        private static Opponent opponentInstance;

        public static Player GetPlayer()
        {
            if (playerInstance == null)
            {
                playerInstance = new Player();
            }

            return playerInstance;
        }
          public static Opponent GetOpponent()
        {
            if (opponentInstance == null)
            {
                opponentInstance = new Opponent();
            }

            return opponentInstance;
        }

    }
}
