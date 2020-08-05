using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace LifeTracker.Application.Model
{
    public class Track
    {
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public Url PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string SpotifyUri { get; set; } 
        public bool Explicit { get; set; }
        public int Duration { get; set; } 
    }
}
