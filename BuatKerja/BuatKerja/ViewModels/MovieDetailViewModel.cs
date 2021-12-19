using System;
using System.Collections.Generic;
using System.Text;
using BuatKerja.Models;

namespace BuatKerja.ViewModels
{
    public class MovieDetailViewModel : BaseViewModel
    {
        private Movie selectedMovie;

        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged();
            }
        }
    }
}
