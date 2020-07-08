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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DogCare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender,RoutedEventArgs e)
        {
            DogInfo.DataContext = App._dogMain;
            Headings.Text = "Feeding your dog";
            DogInfo.SetBinding(TextBlock.TextProperty, "Feeding");

            Uri u = new Uri("Images/img1.jpeg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/img2.jpeg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/img3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/img4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/img5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }
        private void Btn_Feeding_click(object sender, RoutedEventArgs e)
        {

            DogInfo.DataContext = App._dogMain;
            Headings.Text = "Feeding your dog";
            DogInfo.SetBinding(TextBlock.TextProperty, "Feeding");

            Uri u = new Uri("Images/img1.jpeg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/img2.jpeg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/img3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/img4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/img5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }

        private void Btn_Housing_click(object sender, RoutedEventArgs e)
        {
            DogInfo.DataContext = App._dogMain;
            Headings.Text = "A home for your dog";
            DogInfo.SetBinding(TextBlock.TextProperty, "Housing");
            Uri u = new Uri("Images/house1.jpg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/house2.jpg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/house3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/house4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/house5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;

        }

        private void Btn_Handling_click(object sender, RoutedEventArgs e)
        {
            DogInfo.DataContext = App._dogMain;
            Headings.Text = "Handling your Dog";
            DogInfo.SetBinding(TextBlock.TextProperty, "Handling");
            Uri u = new Uri("Images/hand1.jpg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/hand2.jpg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/hand3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/hand4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/hand5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }
    

        private void Btn_Training_click(object sender, RoutedEventArgs e)
        {
        DogInfo.DataContext = App._dogMain;
        Headings.Text = "Training your Dog";
        DogInfo.SetBinding(TextBlock.TextProperty, "Training");

            Uri u = new Uri("Images/train1.jpg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/train2.jpg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/train3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/train4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/train5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }

        private void Btn_Grooming_click(object sender, RoutedEventArgs e)
        {
        DogInfo.DataContext = App._dogMain;
        Headings.Text = "Grooming your Dog";
        DogInfo.SetBinding(TextBlock.TextProperty, "Grooming");

            Uri u = new Uri("Images/grooming1.jpg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/grooming2.jpg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/grooming3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/grooming4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/grooming5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }

        private void Btn_medical_click(object sender, RoutedEventArgs e)
        {

        DogInfo.DataContext = App._dogMain;
        Headings.Text = "Medical care for your Dog";
        DogInfo.SetBinding(TextBlock.TextProperty, "Medical");
            Uri u = new Uri("Images/med1.jpg", UriKind.Relative);
            BitmapImage imgdisplay = new BitmapImage(u);
            Img1.Source = imgdisplay;

            Uri a = new Uri("Images/med2.jpg", UriKind.Relative);
            BitmapImage imgdisplay2 = new BitmapImage(a);
            Img2.Source = imgdisplay2;

            Uri b = new Uri("Images/med3.jpg", UriKind.Relative);
            BitmapImage imgdisplay3 = new BitmapImage(b);
            Img3.Source = imgdisplay3;

            Uri c = new Uri("Images/med4.jpg", UriKind.Relative);
            BitmapImage imgdisplay4 = new BitmapImage(c);
            Img4.Source = imgdisplay4;

            //Uri d = new Uri("Images/med5.jpg", UriKind.Relative);
            //BitmapImage imgdisplay5 = new BitmapImage(d);
            //Img5.Source = imgdisplay5;
        }

    private void Btn_Essentials_click(object sender, RoutedEventArgs e)
        {
            var essentials_Var = new Essential_Window
            {
                Owner = this
            };
            essentials_Var.Show();
        }

        private void Btn_Breeds_click(object sender, RoutedEventArgs e)
        {

            var breeds_Var = new Breeds_Window();
            breeds_Var.Owner = this;
            breeds_Var.Show();
        }
    }
}
