using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _beeingCheckedOut;
        private List<double> _rating;

        public Video(string title)
        {
            _title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _beeingCheckedOut = true;
        }

        public void BeingReturned()
        {
            _beeingCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {   
            return Math.Round(_rating.Average(), 2); 
        }

        public string Available()
        {
            if (_beeingCheckedOut == true)
            { 
                return "It is checked out"; 
            }
            else 
            { 
                return "It is on the shelves";
            }
        }

        public string Title => $"{_title}";

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
