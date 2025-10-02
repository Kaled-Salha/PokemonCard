using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PokemonCard
{
    /// <summary>
    /// Interaction logic for SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        public PokemonCard1 SelectedPokemon { get; set; }
        public SelectionWindow(PokemonCard1 pikachu, PokemonCard1 charmander, PokemonCard1 squirtle)
        {
            InitializeComponent();
            PikachuButton.Tag = pikachu;
            CharmanderButton.Tag = charmander;
            SquirtleButton.Tag = squirtle;
        }
        private void Choose_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            SelectedPokemon = (PokemonCard1)btn.Tag;
            DialogResult = true;
        }
    }
}
