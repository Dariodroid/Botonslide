using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Botonslide
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_SlideCompleted(object sender, System.EventArgs e)
        {
            DisplayAlert("Mensaje", "Completado", "Ok");
        }
    }
}
