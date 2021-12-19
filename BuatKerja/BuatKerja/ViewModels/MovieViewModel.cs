using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuatKerja.Models;
using Xamarin.Forms;


namespace BuatKerja.ViewModels
{
    public class MovieViewModel
    {
        public ObservableCollection<Movie> Movie { get; private set; } = new ObservableCollection<Movie>();
        public MovieViewModel()
        {
            CreateMovieCollections();
        }
        void CreateMovieCollections()
        {
            Movie.Add(new Movie
            {
                Title = "Red Notice",
                ImageUrl = "https://www.ahecdynamics.com.my/images/RedNotice.png",
                VideoUrl = "",
                Genre = "Action",
                Rating = "6.4 / 10",
                Year = "2021",
                Synopsis = "An Interpol agent tracks the world's most wanted art thief."
            });

            Movie.Add(new Movie
            {
                Title = "Free Guy",
                ImageUrl = "https://www.ahecdynamics.com.my/images/freeguy.png",
                VideoUrl = "",
                Genre = "Science Fiction",
                Rating = "7.2 / 10",
                Year = "2021",
                Synopsis = "A bank teller discovers that he's actually an NPC inside a brutal, open world video game."
            });


            Movie.Add(new Movie
            {
                Title = "Mortal Kombat",
                ImageUrl = "https://www.ahecdynamics.com.my/images/MortalKombatMovie.png",
                VideoUrl = "https://www.ahecdynamics.com.my/movies/Mortal_Kombat_(2021).mkv",
                Genre = "Action",
                Rating = "6.1/10",
                Year = "2021",
                Synopsis= "MMA fighter Cole Young seeks out Earth's greatest champions in order to stand against the enemies of Outworld in a high stakes battle for the universe."
            });

            Movie.Add(new Movie
            {
                Title = "Venom Let There Be Carnage",
                ImageUrl = "https://www.ahecdynamics.com.my/images/venom2.png",
                VideoUrl = "",
                Genre = "Action",
                Rating = "6.0 / 10",
                Year = "2021",
                Synopsis = "Eddie Brock attempts to reignite his career by interviewing serial killer Cletus Kasady, who becomes the host of the symbiote Carnage and escapes prison after a failed execution."
            });

            Movie.Add(new Movie
            {
                Title = "James Bond No Time To Die",
                ImageUrl = "https://www.ahecdynamics.com.my/images/jamesbond_nttd.png",
                VideoUrl = "",
                Genre = "Action",
                Rating = "7.4 / 10",
                Year = "2021",
                Synopsis = "James Bond has left active service. His peace is short-lived when Felix Leiter, an old friend from the CIA, turns up asking for help, leading Bond onto the trail of a mysterious villain armed with dangerous new technology."
            });

            Movie.Add(new Movie
            {
                Title = "The Conjuring: The Devil Made Me Do It",
                ImageUrl = "https://www.ahecdynamics.com.my/images/ConjuringDevilMade.png",
                VideoUrl = "",
                Genre = "Horror",
                Rating = "6.3 / 10",
                Year = "2021",
                Synopsis = "The Warrens investigate a murder that may be linked to a demonic possession."
            });
        }
    }
}