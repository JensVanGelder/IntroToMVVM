using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToMVVM.Models
{
    class SongRating
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public string BandName { get; set; }
        public int Rating { get; set; }

        public string StarRating
        {
            get { return RatingToStars(); }
        }
        public SongRating(string songName, string bandName, int rating)
        {
            SongName = songName;
            BandName = bandName;
            Rating = rating;
        }

        public string RatingToStars()
        {
            string result = "";
            for (int i = 0; i < Rating; i++)
            {
                result += "⭐";
            }
            while (result.Length<5)
            {
                result += "▫";
            }
            return result;
        }

    }
}
