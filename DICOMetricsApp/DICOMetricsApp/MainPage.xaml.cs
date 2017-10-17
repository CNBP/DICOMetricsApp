using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DICOMetricsApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();

            DICOMImage.Source = new UriImageSource()
            {
                Uri = new Uri("http://www.satsignal.eu/wxsat/Meteosat7-full-scan.jpg")
            };

            BusinessLogic mainViewModel = new BusinessLogic();
            //mainViewModel.LabelImagesAsync();
            //this.DataContext = mainViewModel;


        }

        private void Clicked(object sender, EventArgs e)
        {
            Button EntryPoint = (Button)sender;
            EntryPoint.Focus();
        }

        public object FindFocusedOne()
        {
            if (button1.IsFocused) return button1;
            else if (button2.IsFocused) return button2;
            else if (button3.IsFocused) return button3;
            else return null;
        }
    }
}
