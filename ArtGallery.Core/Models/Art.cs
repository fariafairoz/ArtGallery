using System;
using System.Collections.Generic;

namespace ArtGallery.Core.Models
{
    
    public class Art
    {
        public long CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public string ShipperName { get; set; }

        public string ShipperPhone { get; set; }

        public double Freight { get; set; }

        public string CustomerFullName { get; set; }

        public string ShipTo { get; set; }

        public double OrderTotal { get; set; }

        public string Status { get; set; }

        

        public ICollection<Artist> Details { get; set; }

        public override string ToString()
        {
            return $"{CustomerFullName} {Status}";
        }

        public string ShortDescription => $"Customer ID: {CustomerID}";
    }
}
