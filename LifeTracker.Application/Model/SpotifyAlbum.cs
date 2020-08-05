using System;
using System.Collections.Generic;

namespace LifeTracker.Application.Model
{
    public class SpotifyAlbum
    {
        public string Album_Type { get; set; }
        public IEnumerable<SpotifyArtist> Artists {get; set;}
        public IEnumerable<string> Available_Markets { get; set; }
        public SpotifyExternalUrls External_Urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public IEnumerable<SpotifyImages> Images { get; set; }
        public string Name { get; set; }
        public DateTime Release_Date { get; set; }
    }
}