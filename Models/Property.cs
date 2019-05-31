using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        public int NumberOfRooms { get; set; }

        public bool Garage { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        public double OwnerPrice { get; set; }
    }
}
