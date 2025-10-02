using System.Windows;

namespace PokemonCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PokemonCard1 _pikachu;
        private PokemonCard1 _charmander;
        private PokemonCard1 _squirtle;
        public MainWindow()
        {
            InitializeComponent();

            _pikachu = new PokemonCard1 
            {
                Name = "Pikachu",
                Hp = "60",
                SubInfo = "Pikachu is a cool guy very heavy very short",
                Type = ElementType.Electric,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Lightning bolt",
                        Damage = "79",
                        Description = "Pbzzzz pszzzt shock",
                        ElementType = ElementType.Electric

                    },
                    new PokemonAttack
                    {
                        Name = "Quick attack",
                        Damage = "20",
                        Description = "Quick as fffff.",
                        ElementType = ElementType.Electric

                    }
                },
                Weakness = "Rock",
                Resistance = "Water",
                Retreat = "Go Home",
                SetNumber = "19/151",
                FooterText = "Always brimming with power, wooooow wooosh mesh pow",
                Rarity = "DOT",
            };
            
            _squirtle = new PokemonCard1
            {
                Name = "Squirtle",
                Hp = "50",
                SubInfo = "Squirtle squirts, that's what squirts do",
                Type = ElementType.Water,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Water bolt",
                        Damage = "9",
                        Description = "Blub blub.",
                        ElementType = ElementType.Water
                    },
                    new PokemonAttack
                    {
                        Name = "Dance Attack",
                        Damage = "20",
                        Description = "Dance as fffffff.",
                        ElementType = ElementType.Water
                    }
                },
                Weakness = "Electric",
                Resistance = "Fire",
                Retreat = "Go Home",
                SetNumber = "7/151",
                FooterText = "Squirtle likes to squirtle.",
                Rarity = "DOT",
            };

            _charmander = new PokemonCard1
            {
                Name = "Charmander",
                Hp = "70",
                SubInfo = "Charmander is very firey and burns bright",
                Type = ElementType.Fire,
                Attacks =
                {
                    new PokemonAttack
                    {
                        Name = "Fire bolt",
                        Damage = "29",
                        Description = "Fwoosh fwoosh.",
                        ElementType = ElementType.Fire
                    },
                    new PokemonAttack
                    {
                        Name = "Flame Tail",
                        Damage = "40",
                        Description = "Flame as fffffff.",
                        ElementType = ElementType.Fire
                    }
                },
                Weakness = "Water",
                Resistance = "Grass",
                Retreat = "Go Home",
                SetNumber = "4/151",
                FooterText = "Potatoes will potateeeeeeee",
                Rarity = "DOT"
            };



            SetUpWindow(_pikachu);

        }

        public void OpenSelectionWindowClick(Object sender, RoutedEventArgs e) 
        {
            var picker = new SelectionWindow(_pikachu, _charmander, _squirtle) { Owner = this };
            if (picker.ShowDialog() == true)
            { 
                SetUpWindow(picker.SelectedPokemon);
            }
        }

        public void SetUpWindow(PokemonCard1 pokemon)
        {
            NameTextBlock.Text = pokemon.Name;
            HpTextBlock.Text = pokemon.Hp;
            SubInfoTextBlock.Text = pokemon.SubInfo;

            Attack1IconTextBlock.Text = pokemon.Attacks[0].ElementType.ToString();
            Attack1NameTextBlock.Text = pokemon.Attacks[0].Name;
            Attack1DMGTextBlock.Text = pokemon.Attacks[0].Damage;
            Attack1DescTextBlock.Text = pokemon.Attacks[0].Description;

            Attack2IconTextBlock.Text = pokemon.Attacks[1].ElementType.ToString();
            Attack2NameTextBlock.Text = pokemon.Attacks[1].Name;
            Attack2DMGTextBlock.Text = pokemon.Attacks[1].Damage;
            Attack2DescTextBlock.Text = pokemon.Attacks[1].Description;

            WeaknessTextBlock.Text = pokemon.Weakness;
            ResistanceTextBlock.Text = pokemon.Resistance;
            RetreatTextBlock.Text = pokemon.Retreat;

            SetNumberTextBlock.Text = pokemon.SetNumber;
            FooterTextTextBlock.Text = pokemon.FooterText;
            CopyRightTextBlock.Text = pokemon.Rarity;


        }
    }
}