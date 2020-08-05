using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace LifeTracker.Application.Model
{
    public class SpotifyTrack
    {
        public SpotifyAlbum Album { get; set; }
        public IEnumerable<SpotifyArtist> Artists { get; set; }
        public IEnumerable<string> Available_Markets { get; set; }
        public int Duration_Ms { get; set; }
        public bool Explicit { get; set; }
        public SpotifyExternalUrls External_Urls {get;set;}
        public string Href { get; set; }
        public string Id { get; set; }
        public IEnumerable<SpotifyImages> Images { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public Url Preview_Url { get; set; }
        public int Track_Number { get; set; }
        public Uri Uri { get; set; }
    }
}