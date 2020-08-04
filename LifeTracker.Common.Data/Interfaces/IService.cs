using LifeTracker.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LifeTracker.Application.Interfaces
{
    public interface ISpotifyTracksService 
    {
        public IEnumerable<Track> GetUserPopularTracks();
    }
}
