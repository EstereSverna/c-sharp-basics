using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    { 
        private List<Video> _videoList;

        public VideoStore()
        {
            _videoList = new List<Video>();      
        }

        public void AddVideo(string title)
        {

            _videoList.Add(new Video(title));
        }

        public void Checkout(string title)
        {
             _videoList.Single(video => video.Title == title).BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            _videoList.Single(video => video.Title == title).BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            _videoList.Single(video => video.Title == title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            foreach (Video video in _videoList)
            {
                    Console.WriteLine(video.ToString());              
            }
        }
    }
}
