using System;
using RealEstate.Models;
using System.Linq;

namespace RealEstate.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RealEstateContext context)
        {
            context.Database.EnsureCreated();

            // Look for any property.
            if (context.Properties.Any())
            {
                return;   // DB has been seeded
            }

            var properties = new Property[]
            {
                new Property{ Address ="Calle Capuchinos 23 2A", NumberOfRooms = 3, City = "Malaga", Garage= false, OwnerPrice = 150000},
                new Property{ Address ="Calle Ayala 74 5B", NumberOfRooms = 1, City = "Malaga", Garage= true, OwnerPrice = 140000},
                new Property{ Address ="Calle San Cristobal 53 5A", NumberOfRooms = 2, City = "Malaga", Garage= false, OwnerPrice = 250000},
                new Property{ Address ="Calle Beatas 39 1C", NumberOfRooms = 2, City = "Malaga", Garage= true, OwnerPrice = 540000},
                new Property{ Address ="Calle Alamos 46 2A", NumberOfRooms = 3, City = "Malaga", Garage= true, OwnerPrice = 690000},
                new Property{ Address ="Calle Carreteria 56 6B", NumberOfRooms = 5, City = "Malaga", Garage= false, OwnerPrice = 850000},
                new Property{ Address ="Calle Real 88 1C", NumberOfRooms = 2, City = "Cordoba", Garage= false, OwnerPrice = 450000}
            };

            foreach (Property p in properties)
            {
                context.Properties.Add(p);
            }
            context.SaveChanges();
        }
    }
}
