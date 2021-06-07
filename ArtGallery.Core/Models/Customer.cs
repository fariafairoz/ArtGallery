using System;
using System.Collections.Generic;

namespace ArtGallery.Core.Models
{
    
    public class Customer
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public ICollection<Art> artinfo { get; set; }
    }
}
