using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DogCare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static ObservableCollection<Essentials_Class> _essential1;
        public static ObservableCollection<GeneralDogCare_Class> _dogMain;
        public static ObservableCollection<Breeds_Class> _breeds;
        private void Application_Startup(object sender, StartupEventArgs e)
        {

           _essential1 = new ObservableCollection<Essentials_Class>();

            //_essential1 = GenerateEssentials(2);
            _essential1 = Dog_Storage.ReadXml<ObservableCollection<Essentials_Class>>("EssentialsList.xml");

            //if (_essential1 == null)
            //{
            //    _essential1 = new ObservableCollection<Essentials_Class>();
            //}

            //_breeds = Generatebreed(1);
            _breeds = Dog_Storage.ReadXml<ObservableCollection<Breeds_Class>>("DogBreeds.xml");
            if (_breeds == null)
            {
                _breeds = new ObservableCollection<Breeds_Class>();
            }



            //_dogMain = GenerateInfo(1);
            _dogMain = Dog_Storage.ReadXml<ObservableCollection<GeneralDogCare_Class>>("GeneralDogInfoList.xml");




        }
        //private ObservableCollection<Breeds_Class> Generatebreed(int count)
        //{
        //    var lst1 = new ObservableCollection<Breeds_Class>();
        //    for (int i = 0; i < count; i++)
        //    {
        //        lst1.Add(new Breeds_Class { BreedGroup = "Beagle" + i, Origin = "England" + i, Size = "100" + i, LifeSpan = "10 years" + i, EnergyLevel = "High" + i, Description = "High energy dog" + i, Imagepath1 = "feed1.jpeg/Images" + i, Imagepath2 = "feed1.jpeg/Images" + i, Imagepath3 = "feed1.jpeg/Images" + i, Imagepath4 = "feed1.jpeg/Images" + i, Imagepath5 = "feed1.jpeg/Images" + i });
        //    }


        //    return lst1;
        //}


        //private ObservableCollection<GeneralDogCare_Class> GenerateInfo(int v)
        //{
        //    var infolst = new ObservableCollection<GeneralDogCare_Class>();

        //    infolst.Add(new GeneralDogCare_Class { Feeding = "Hi" });
        //    return infolst;

        //}


        //private ObservableCollection<Essentials_Class> GenerateEssentials(int v)

        //{
        //    var lstd = new ObservableCollection<Essentials_Class>();
        //    //for (int i = 0; i < count; i++)
        //    //{
        //    //    lst.Add(new Essentials { EssentialName = "Dog_Crate" + i  , EssentialDescription = "ad " + i });
        //    //}
        //    lstd.Add(new Essentials_Class { EssentialName = "Dog_Crate", EssentialDescription = "ad ", Imgpath1 = "Images/feed1.jpeg", Imgpath2 = "Images/feed1.jpeg", Imgpath3 = "Images/feed1.jpeg", Imgpath4 = "Images/feed1.jpeg", Imgpath5 = "Images/feed1.jpeg" });


        //    return lstd;
        //}

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            //Dog_Storage.WriteXml<ObservableCollection<Essentials_Class>>(_essential1, "EssentialsList.xml");

            //Dog_Storage.WriteXml<ObservableCollection<GeneralDogCare_Class>>(_dogMain, "GeneralDogInfoList.xml");

            //Dog_Storage.WriteXml<ObservableCollection<Breeds_Class>>(_breeds, "DogBreeds.xml");
        }
    }
}
