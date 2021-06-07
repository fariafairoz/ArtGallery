using System;

namespace ArtGallery.Core.Models
{
   
    public class Artist
    {
        public long ArtistID { get; set; }

        public string ArtistName { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public string QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public double Total { get; set; }

        public string ShortDescription => $"Artist ID: {ArtistID} - {ArtistName}";
    }
}
