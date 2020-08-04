using System;
using System.Collections;
using System.Collections.Generic;

namespace LifeTracker.Application.Model
{
    public class SpotifyArtist
    {
        public IEnumerable<SpotifyExternalUrls> External_Urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public Uri Uri { get; set; }
    }
}