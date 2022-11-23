using MTGO_lite.Models.Manas;
using System.Diagnostics;

namespace mtg_lite.Models.Cards
{
    [DebuggerDisplay("{Name}")]
    public class Card
    {
        private string name;
        private Mana manaCost;
        private Bitmap picture;
        private bool tapped;
        private Guid guid;
        private string type;

        public string Name { get => name; }
        public Bitmap Picture { get => picture; }
        public bool Tapped { get => tapped; set => ChangeTapped(value); }
        public Mana ManaCost { get => manaCost; }
        public virtual bool IsPermanent { get => false; }
        public string Type { get => type; }

        public event EventHandler<bool>? TappedChanged;

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">Nom de la carte</param>
        /// <param name="type">Type de la carte</param>
        /// <param name="manaCost">Le coût de la carte</param>
        /// <param name="picture">L'image de la carte qui est situé dans le fichier Ressource</param>
        public Card(string name, string type, Mana manaCost, Bitmap picture)
        {
            this.name = name;
            this.manaCost = manaCost;
            this.picture = picture;
            this.type = type;
            tapped = false;
            guid = Guid.NewGuid();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="value">verifie si la carte est tapped (true) ou elle ne l'est pas(false) (</param>
        private void ChangeTapped(bool value)
        {
            TappedChanged?.Invoke(this, tapped);
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return card1.guid == card2.guid;
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
    }
}