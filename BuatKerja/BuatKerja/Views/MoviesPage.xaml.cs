﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuatKerja.ViewModels;
using BuatKerja.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuatKerja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesPage : ContentPage
    {
        public MoviesPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoviesDetailPage());
        }
    }
}