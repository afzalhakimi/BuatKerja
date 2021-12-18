using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaManager.Forms;
using MediaManager;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BuatKerja.Models;
using BuatKerja.ViewModels;

namespace BuatKerja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesDetailPage : ContentPage
    {
        public MoviesDetailPage()
        {
            InitializeComponent();

        }
    }
}