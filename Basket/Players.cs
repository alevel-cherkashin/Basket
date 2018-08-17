using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public abstract class Players
    {

        static int basketWeight;
        public Random rnd;

        public int[] arrayWeight;

        protected string playerName;
        protected int playerWeight;

        public Players()
        {
            rnd = new Random();
            basketWeight = rnd.Next(40, 140);
            setArray();
        }

        protected abstract void GuessWeight();
        
        protected void SetValueInArray (int value)
        {
            for (int i = 0; i < arrayWeight.Length; i++)
            {
                if (arrayWeight[i] == 0)
                {
                    arrayWeight[i] = value;
                }
            }
        }

        private void setArray()
        {
            arrayWeight = new int[99];

            for (int i = 0; i < arrayWeight.Length; i++)
            {
                arrayWeight[i] = 0;
            }
        }

    }
}
