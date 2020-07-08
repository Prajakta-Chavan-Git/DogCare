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
    /// Interaction logic for Essential_Window.xaml
    /// </summary>
    public partial class Essential_Window : Window
    {
        public Essential_Window()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Essential_List.ItemsSource = App._essential1;
        }

        private void Essential_Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = (sender as TextBox).Text.ToLower();
            var lstd = from m in App._essential1 where m.EssentialName.ToLower().Contains(input) select m;
            Essential_List.ItemsSource = lstd;

           
        }
    }
}
