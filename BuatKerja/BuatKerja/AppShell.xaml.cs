
using BuatKerja.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BuatKerja
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
         
        }
    }
}
