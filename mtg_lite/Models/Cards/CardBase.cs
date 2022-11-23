using System.Diagnostics;

namespace mtg_lite.Models.Cards
{
    [DebuggerDisplay("{Name}")]
    public class CardBase
    {
        public event EventHandler<bool>? TappedChanged;
    }
}