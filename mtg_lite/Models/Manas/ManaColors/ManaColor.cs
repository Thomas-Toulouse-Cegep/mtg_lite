using System.Diagnostics;

namespace MTGO_lite.Models.Manas.ManaColors
{
    [DebuggerDisplay("{ColorName}({Quantity})")]
    public abstract class ManaColor
    {
        public event EventHandler<ManaColor>? QuantityChanged;
        public event EventHandler<int>? QuantityChangedInt;

        protected int quantity;

        public int Quantity { get => quantity; }
        public abstract string ColorName { get; }
        public abstract Bitmap Icon { get; }

        protected ManaColor(int quantity)
        {
            this.quantity = quantity;
        }

        public ManaColor(ManaColor manaColor)
        {
            this.quantity = manaColor.quantity;
        }

        public void Add(ManaColor mana)
        {
            this.quantity += mana.quantity;
            QuantityChanged?.Invoke(this, mana);
        }

        public void Remove(ManaColor mana)
        {
            this.quantity -= mana.quantity;
            QuantityChanged?.Invoke(this, mana);
        }

        public void Remove(int quantity)
        {
            this.quantity -= quantity;
            QuantityChangedInt?.Invoke(this, quantity);
        }

        public override string ToString()
        {
            return $"{ColorName}: {Quantity}";
        }

        public static bool operator <(ManaColor a, ManaColor b)
        {
            return a.quantity < b.quantity;
        }

        public static bool operator >(ManaColor a, ManaColor b)
        {
            return a.quantity > b.quantity;
        }
    }
}