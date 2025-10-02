using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCard
{
    public class PokemonCard1
    {
        public string Name { get; set; }

        public string Hp { get; set; }

        public ElementType Type { get; set; }

        public string imagePath { get; set; }

        public string SubInfo { get; set; }

        public string Weakness { get; set; }

        public string Resistance { get; set; }

        public string Retreat { get; set; }

        public string SetNumber { get; set; }

        public string FooterText { get; set; }

        public string Rarity { get; set; }

        public List<PokemonAttack> Attacks { get; set; } = new List<PokemonAttack>();
        //eller: = new();

    }

    public enum ElementType
    {
        Fire, Water, Grass, Electric, Psychic, Fighting, Dark, Fairy, Dragon, Steel, Colorless
    }
}
