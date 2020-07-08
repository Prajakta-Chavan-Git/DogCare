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

namespace DogCare
{
    /// <summary>
    /// Interaction logic for Breeds_Window.xaml
    /// </summary>
    public partial class Breeds_Window : Window
    {
        public Breeds_Window()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            Breed_List.ItemsSource = App._breeds;
        }
        private void Breed_Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = (sender as TextBox).Text.ToLower();
            var lst1 = from s in App._breeds where s.BreedGroup.ToLower().Contains(input) select s;
            Breed_List.ItemsSource = lst1;
        }
    }
}
