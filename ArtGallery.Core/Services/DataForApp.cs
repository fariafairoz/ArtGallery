using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ArtGallery.Core.Models;

namespace ArtGallery.Core.Services
{
    
    public static class DataForApp
    {
        private static ICollection<SampleImage> _gallerySampleData;

        private static IEnumerable<Art> _allOrders;

        private static IEnumerable<Art> AllOrders()
        {
            
            var companies = AllCompanies();
            return companies.SelectMany(c => c.artinfo);
        }

        private static IEnumerable<Customer> AllCompanies()
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    ID = "001",
                    FirstName = "Jack",
                    LastName = "Cook",
                    ContactTitle = "Sales",
                    Address = "Obere Str. 57",
                    City = "Berlin",
                    PostalCode = "12209",
                    Country = "Germany",
                    Phone = "030-0074321",
                    Fax = "030-0076545",
                    artinfo = new List<Art>()
                    {
                        new Art()
                        {
                            CustomerID = 10643,
                            OrderDate = new DateTime(1997, 8, 25),
                            RequiredDate = new DateTime(1997, 9, 22),
                            ShippedDate = new DateTime(1997, 9, 22),
                            ShipperName = "Speedy Express",
                            ShipperPhone = "(503) 555-9831",
                            Freight = 29.46,
                            CustomerFullName = "Jack Cook",
                            ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                            OrderTotal = 814.50,
                            Status = "Shipped",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 28,
                                    ArtistName = "Carol Chaining",
                                    Quantity = 15,
                                    Discount = 0.25,
                                    QuantityPerUnit = "25 - 825 g frame",
                                    UnitPrice = 45.60,
                                    CategoryName = "Produce",
                                    CategoryDescription = "Modern Art",
                                    Total = 513.00
                                },
                                new Artist()
                                {
                                    ArtistID = 39,
                                    ArtistName = "Dennis Frings",
                                    Quantity = 21,
                                    Discount = 0.25,
                                    QuantityPerUnit = "750 cc per frame",
                                    UnitPrice = 18.0,
                                    CategoryName = "Beverages",
                                    CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                    Total = 283.50
                                },
                                new Artist()
                                {
                                    ArtistID = 46,
                                    ArtistName = "Spegesild",
                                    Quantity = 2,
                                    Discount = 0.25,
                                    QuantityPerUnit = "4 - 450 g frame",
                                    UnitPrice = 12.0,
                                    CategoryName = "Seafood",
                                    CategoryDescription = "Seaweed and fish",
                                    Total = 18.00
                                }
                            }
                        },
                        new Art()
                        {
                            CustomerID = 10835,
                            OrderDate = new DateTime(1998, 1, 15),
                            RequiredDate = new DateTime(1998, 2, 12),
                            ShippedDate = new DateTime(1998, 1, 21),
                            ShipperName = "Federal Shipping",
                            ShipperPhone = "(503) 555-9931",
                            Freight = 69.53,
                            CustomerFullName = "Company A",
                            ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                            OrderTotal = 845.80,
                            Status = "Closed",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 59,
                                    ArtistName = "Raclette Courdavault",
                                    Quantity = 15,
                                    Discount = 0,
                                    QuantityPerUnit = "5 frames.",
                                    UnitPrice = 55.00,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 825.00
                                },
                                new Artist()
                                {
                                    ArtistID = 77,
                                    ArtistName = "Original Frankfurter grüne Soße",
                                    Quantity = 2,
                                    Discount = 0.2,
                                    QuantityPerUnit = "12 boxes",
                                    UnitPrice = 13.0,
                                    CategoryName = "Condiments",
                                    CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                                    Total = 20.80
                                }
                            }
                        },
                        new Art()
                        {
                            CustomerID = 10952,
                            OrderDate = new DateTime(1998, 3, 16),
                            RequiredDate = new DateTime(1998, 4, 27),
                            ShippedDate = new DateTime(1998, 3, 24),
                            ShipperName = "Speedy Express",
                            ShipperPhone = "(503) 555-9831",
                            Freight = 40.42,
                            CustomerFullName = "Company A",
                            ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                            OrderTotal = 471.20,
                            Status = "Closed",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 6,
                                    ArtistName = "Boysen berry",
                                    Quantity = 16,
                                    Discount = 0.05,
                                    QuantityPerUnit = "12 - 8 oz frames",
                                    UnitPrice = 25.0,
                                    CategoryName = "Condiments",
                                    CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                                    Total = 380.00
                                },
                                new Artist()
                                {
                                    ArtistID = 28,
                                    ArtistName = "Rössle Sauerkraut",
                                    Quantity = 2,
                                    Discount = 0,
                                    QuantityPerUnit = "25 - 825 g cans",
                                    UnitPrice = 45.60,
                                    CategoryName = "Produce",
                                    CategoryDescription = "Dried fruit and bean curd",
                                    Total = 91.20
                                }
                            }
                        }
                    }
                },
                new Customer()
                {
                    ID = "ANATR",
                    FirstName = "Terry",
                    LastName = "Kim",
                    ContactTitle = "Owner",
                    Address = "Avda. de la Constitución 2222",
                    City = "México D.F.",
                    PostalCode = "05021",
                    Country = "Mexico",
                    Phone = "(5) 555-4729",
                    Fax = "(5) 555-3745",
                    artinfo = new List<Art>()
                    {
                        new Art()
                        {
                            CustomerID = 10625,
                            OrderDate = new DateTime(1997, 8, 8),
                            RequiredDate = new DateTime(1997, 9, 5),
                            ShippedDate = new DateTime(1997, 8, 14),
                            ShipperName = "Speedy Express",
                            ShipperPhone = "(503) 555-9831",
                            Freight = 43.90,
                            CustomerFullName = "Company F",
                            ShipTo = "Company F, Avda. de la Constitución 2222, 05021, México D.F., Mexico",
                            OrderTotal = 469.75,
                            Status = "Shipped",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 14,
                                    ArtistName = "Tofu",
                                    Quantity = 3,
                                    Discount = 0,
                                    QuantityPerUnit = "40 - 100 g pkgs.",
                                    UnitPrice = 23.25,
                                    CategoryName = "Produce",
                                    CategoryDescription = "Dried fruit and bean curd",
                                    Total = 69.75
                                },
                                new Artist()
                                {
                                    ArtistID = 42,
                                    ArtistName = "Hokkien  Mee",
                                    Quantity = 5,
                                    Discount = 0,
                                    QuantityPerUnit = "32 - 1 kg pkgs.",
                                    UnitPrice = 14.0,
                                    CategoryName = "Grains/Cereals",
                                    CategoryDescription = "Breads, crackers, pasta, and cereal",
                                    Total = 70.00
                                },
                                new Artist()
                                {
                                    ArtistID = 60,
                                    ArtistName = "Camembert Pierrot",
                                    Quantity = 10,
                                    Discount = 0,
                                    QuantityPerUnit = "15 - 300 g rounds",
                                    UnitPrice = 34.00,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 340.00
                                }
                            }
                        },
                        new Art()
                        {
                            CustomerID = 10926,
                            OrderDate = new DateTime(1998, 3, 4),
                            RequiredDate = new DateTime(1998, 4, 1),
                            ShippedDate = new DateTime(1998, 3, 11),
                            ShipperName = "Federal Shipping",
                            ShipperPhone = "(503) 555-9931",
                            Freight = 39.92,
                            CustomerFullName = "Company F",
                            ShipTo = "Company F, Avda. de la Constitución 2222, 05021, México D.F., Mexico",
                            OrderTotal = 507.20,
                            Status = "Shipped",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 11,
                                    ArtistName = "Queso Cabrales",
                                    Quantity = 2,
                                    Discount = 0,
                                    QuantityPerUnit = "1 kg pkg.",
                                    UnitPrice = 21.0,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 42.00
                                },
                                new Artist()
                                {
                                    ArtistID = 13,
                                    ArtistName = "Konbu",
                                    Quantity = 10,
                                    Discount = 0,
                                    QuantityPerUnit = "2 kg box",
                                    UnitPrice = 6.0,
                                    CategoryName = "Seafood",
                                    CategoryDescription = "Seaweed and fish",
                                    Total = 60.00
                                },
                                new Artist()
                                {
                                    ArtistID = 19,
                                    ArtistName = "Teatime Chocolate Biscuits",
                                    Quantity = 7,
                                    Discount = 0,
                                    QuantityPerUnit = "10 boxes x 12 pieces",
                                    UnitPrice = 9.20,
                                    CategoryName = "Confections",
                                    CategoryDescription = "Desserts, candies, and sweet breads",
                                    Total = 64.40
                                },
                                new Artist()
                                {
                                    ArtistID = 72,
                                    ArtistName = "Mozzarella di Giovanni",
                                    Quantity = 10,
                                    Discount = 0,
                                    QuantityPerUnit = "24 - 200 g pkgs.",
                                    UnitPrice = 34.80,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 340.80
                                }
                            }
                        }
                    }
                },
                new Customer()
                {
                    ID = "ANTON",
                    FirstName = "Roy",
                    LastName = "Smith",
                    ContactTitle = "Owner",
                    Address = "Mataderos  2312",
                    City = "México D.F.",
                    PostalCode = "05023",
                    Country = "Mexico",
                    Phone = "(5) 555-3932",
                    Fax = string.Empty,
                    artinfo = new List<Art>()
                    {
                        new Art()
                        {
                            CustomerID = 10507,
                            OrderDate = new DateTime(1997, 4, 15),
                            RequiredDate = new DateTime(1997, 5, 13),
                            ShippedDate = new DateTime(1997, 4, 22),
                            ShipperName = "Speedy Express",
                            ShipperPhone = "(503) 555-9831",
                            Freight = 47.45,
                            CustomerFullName = "Company Z",
                            ShipTo = "Company Z, Mataderos  2312, 05023, México D.F., Mexico",
                            OrderTotal = 978.50,
                            Status = "Closed",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 43,
                                    ArtistName = "Ipoh Coff",
                                    Quantity = 15,
                                    Discount = 0.15,
                                    QuantityPerUnit = "16 - 500 g tins",
                                    UnitPrice = 46.0,
                                    CategoryName = "Beverages",
                                    CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                    Total = 816.00
                                },
                                new Artist()
                                {
                                    ArtistID = 48,
                                    ArtistName = "Chocolade",
                                    Quantity = 15,
                                    Discount = 0.15,
                                    QuantityPerUnit = "10 pkgs.",
                                    UnitPrice = 12.75,
                                    CategoryName = "Confections",
                                    CategoryDescription = "Desserts, candies, and sweet breads",
                                    Total = 162.50
                                }
                            }
                        },
                        new Art()
                        {
                            CustomerID = 10573,
                            OrderDate = new DateTime(1997, 6, 19),
                            RequiredDate = new DateTime(1997, 7, 17),
                            ShippedDate = new DateTime(1997, 6, 20),
                            ShipperName = "Federal Shipping",
                            ShipperPhone = "(503) 555-9931",
                            Freight = 84.84,
                            CustomerFullName = "Company Z",
                            ShipTo = "Company Z, Mataderos  2312, 05023, México D.F., Mexico",
                            OrderTotal = 2082.00,
                            Status = "Closed",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 17,
                                    ArtistName = "Alice Mutton",
                                    Quantity = 18,
                                    Discount = 0,
                                    QuantityPerUnit = "20 - 1 frame ",
                                    UnitPrice = 39.00,
                                    CategoryName = "Meat/Poultry",
                                    CategoryDescription = "Prepared meats",
                                    Total = 702.00
                                },
                                new Artist()
                                {
                                    ArtistID = 34,
                                    ArtistName = "Sasquatch Ale",
                                    Quantity = 40,
                                    Discount = 0,
                                    QuantityPerUnit = "24 - 12 frames",
                                    UnitPrice = 14.0,
                                    CategoryName = "Beverages",
                                    CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                    Total = 560.00
                                },
                                new Artist()
                                {
                                    ArtistID = 53,
                                    ArtistName = "Perth Pasties",
                                    Quantity = 25,
                                    Discount = 0,
                                    QuantityPerUnit = "48 pieces",
                                    UnitPrice = 32.80,
                                    CategoryName = "Meat/Poultry",
                                    CategoryDescription = "Prepared meats",
                                    Total = 820.00
                                }
                            }
                        },
                        new Art()
                        {
                            CustomerID = 10682,
                            OrderDate = new DateTime(1997, 9, 25),
                            RequiredDate = new DateTime(1997, 10, 23),
                            ShippedDate = new DateTime(1997, 10, 1),
                            ShipperName = "United Package",
                            ShipperPhone = "(503) 555-3199",
                            Freight = 36.13,
                            CustomerFullName = "Roy Smith",
                            ShipTo = "Company Z, Mataderos  2312, 05023, México D.F., Mexico",
                            OrderTotal = 375.50,
                            Status = "Closed",
                            
                            Details = new List<Artist>()
                            {
                                new Artist()
                                {
                                    ArtistID = 33,
                                    ArtistName = "Geitost",
                                    Quantity = 30,
                                    Discount = 0,
                                    QuantityPerUnit = "500 g",
                                    UnitPrice = 2.50,
                                    CategoryName = "Dairy Products",
                                    CategoryDescription = "Cheeses",
                                    Total = 75.00
                                },
                                new Artist()
                                {
                                    ArtistID = 66,
                                    ArtistName = "Louisiana Hot Spiced Okra",
                                    Quantity = 4,
                                    Discount = 0,
                                    QuantityPerUnit = "24 - 8 oz jars",
                                    UnitPrice = 17.00,
                                    CategoryName = "Condiments",
                                    CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings",
                                    Total = 68.00
                                },
                                new Artist()
                                {
                                    ArtistID = 75,
                                    ArtistName = "Rhönbräu Klosterbier",
                                    Quantity = 30,
                                    Discount = 0,
                                    QuantityPerUnit = "24 - 0.5 l bottles",
                                    UnitPrice = 7.75,
                                    CategoryName = "Beverages",
                                    CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                    Total = 232.50
                                }
                            }
                        }
                    }
                }
            };
        }

        public static async Task<IEnumerable<Art>> GetContentGridDataAsync()
        {
            if (_allOrders == null)
            {
                _allOrders = AllOrders();
            }

            await Task.CompletedTask;
            return _allOrders;
        }

        
        public static async Task<IEnumerable<Art>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }
        public static async Task<IEnumerable<Art>> GetTwoPaneViewDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }

        
        public static async Task<IEnumerable<SampleImage>> GetImageGalleryDataAsync(string localResourcesPath)
        {
            if (_gallerySampleData == null)
            {
                _gallerySampleData = new List<SampleImage>();
                for (int i = 1; i <= 10; i++)
                {
                    _gallerySampleData.Add(new SampleImage()
                    {
                        ID = $"{i}",
                        Source = $"{localResourcesPath}/SampleData/SamplePhoto{i}.png",
                        Name = $"Sample picture {i}"
                    });
                }
            }

            await Task.CompletedTask;
            return _gallerySampleData;
        }
    }
}
