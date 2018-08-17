using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    class NormalPlayer: Players
    {
        public NormalPlayer(string name): base()
        {
            playerName = name;
        }

        protected override void GuessWeight()
        {
            playerWeight = rnd.Next(40, 140);

            SetValueInArray(playerWeight);
        }
    }
}
