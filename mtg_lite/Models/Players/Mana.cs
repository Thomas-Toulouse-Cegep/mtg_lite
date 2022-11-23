using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGO_lite.Models.Manas.ManaColors;

namespace MTGO_lite.Models.Manas
{
    public class Mana
    {
        private Dictionary<string, ManaColor> manaColors;

        public ManaColor White
        {
            get => manaColors[ManaWhite.Name];
        }

        public ManaColor Blue
        {
            get => manaColors[ManaBlue.Name];
        }

        public ManaColor Black
        {
            get => manaColors[ManaBlack.Name];
        }

        public ManaColor Red
        {
            get => manaColors[ManaRed.Name];
        }

        public ManaColor Green
        {
            get => manaColors[ManaGreen.Name];
        }

        public ManaColor Colorless
        {
            get => manaColors[ManaColorless.Name];
        }

        public Dictionary<string, ManaColor> ManaColors { get => manaColors; }

        public Mana() : this(0, 0, 0, 0, 0, 0)
        {
        }

        public Mana(int black, int blue, int green, int red, int white, int colorless)
        {
            manaColors = new Dictionary<string, ManaColor>()
            {
                { ManaBlack.Name, new ManaBlack(black)},
                { ManaBlue.Name, new ManaBlue(blue)},
                { ManaGreen.Name, new ManaGreen(green)},
                { ManaRed.Name, new ManaRed(red)},
                { ManaWhite.Name, new ManaWhite(white)},
                { ManaColorless.Name, new ManaColorless(colorless)},
            };
        }

        /// <summary>
        /// verify if user can pay for this card
        /// </summary>
        /// <param name="manaToPay">the mana to remove from the mana pool</param>
        /// <exception cref="Exception"> tell user he can't pay for this card</exception>
        public void Pay(Mana manaToPay)
        {
            if (payable(manaToPay))
            {
                foreach (var manaColor in manaToPay.manaColors)
                {
                    manaColors[manaColor.Key].Remove(manaColor.Value);
                }
            }
            else
            {
                throw new Exception("non payable");
            }
        }

        public void Add(Mana mana)
        {
            foreach (var manaColor in mana.manaColors)
            {
                manaColors[manaColor.Key].Add(manaColor.Value);
            }
        }

        /// <summary>
        /// this function check all the mana type the card use
        /// </summary>
        /// <param name="manaToPay"> the cost to pay to use this card</param>
        /// <returns> return a true or a false if you can pay to use this card</returns>
        public bool payable(Mana manaToPay)
        {
            foreach (var manaColor in manaToPay.manaColors)
            {
                if (manaColor.Key == ManaColorless.Name)
                {
                    continue;
                }
                if (manaColors[manaColor.Key] < manaColor.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}