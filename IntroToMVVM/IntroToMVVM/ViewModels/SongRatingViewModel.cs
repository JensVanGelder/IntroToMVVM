using IntroToMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace IntroToMVVM.ViewModels
{
    class SongRatingViewModel
    {
        public ObservableCollection<SongRating> SongRatings { get; set; }
        public string NewSongName { get; set; }
        public string NewBandName { get; set; }
        public int NewRating { get; set; }
        public Command AddRatingCommand => new Command(AddItem);
        public SongRatingViewModel()
        {
            SongRatings = new ObservableCollection<SongRating>
            {
                new SongRating("Descent", "Humanity's Last Breath", 4),
                new SongRating("The Mara Effect", "Spiritbox", 4),
                new SongRating("Sandstorm", "Darude", 5),
            };
        }
        private void AddItem()
        {
            SongRatings.Add(new SongRating(NewSongName, NewBandName, NewRating));
        }
    }
}
