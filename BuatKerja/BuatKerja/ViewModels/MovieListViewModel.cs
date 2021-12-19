using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using BuatKerja.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using BuatKerja.Views;

namespace BuatKerja.ViewModels
{
    public class MovieListViewModel : BaseViewModel
    {
        public MovieListViewModel()
        {
            GetOnlineData();
        }
        public Movie FeaturedMovie => WatchList?.Where(x => x.IsFeatured == true).FirstOrDefault();

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

        private ObservableCollection<Movie> watchList;

        public ObservableCollection<Movie> WatchList
        {
            get { return watchList; }
            set 
            {
                watchList = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FeaturedMovie));
            }
        }

        public ICommand SelectionCommand => new Command(() =>
        {
            if(SelectedMovie != null)
            {
                var viewmodels = new MovieDetailViewModel { SelectedMovie = selectedMovie };
                var page = new MoviesDetailPage { BindingContext = viewmodels };
                Application.Current.MainPage.Navigation.PushAsync(page);
            }
        });

        private async void GetOnlineData()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://www.ahecdynamics.com.my/movie.json");
            WatchList = JsonConvert.DeserializeObject<ObservableCollection<Movie>>(result);
        }
    }
}
