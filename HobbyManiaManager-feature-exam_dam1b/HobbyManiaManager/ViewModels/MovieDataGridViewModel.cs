using System;
using HobbyManiaManager.Models;

namespace HobbyManiaManager.ViewModels
{
    public class MovieDataGridViewModel
    {

        private RentalService _rentalService = new RentalService();

        public MovieDataGridViewModel(Movie m)
        {
            Id = m.Id;
            Title = m.Title;
            OriginalTitle = m.OriginalTitle;
            ReleaseDate = m.ReleaseDate;
            VoteAverage = Math.Round(m.VoteAverage *10);
            IsAvailable = _rentalService.IsAvailable(m);
        }

        public int Id { get; set; }

        public string Title { get; set; }
        
        public string OriginalTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double VoteAverage { get; set; }

        public bool IsAvailable { get; set; }
    }
}