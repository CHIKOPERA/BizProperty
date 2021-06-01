using Domain.Common;
using Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Listing : Record
    {
        public Listing()
        {
            Anemities = new HashSet<Anemity>();
            SpecialRooms = new HashSet<SpecialRooms>();
        }
        public int ListingId { get; set; }
        public string Title { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal RentalPrice { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public bool HasParking { get; set; }
        public bool HasSecurity { get; set; }
        public bool HasSmokeDetectors { get; set; }
        public bool IsFurnished { get; set; }
        public bool HasElectricityMeter { get; set; }
        public int TotalNumberOfOccupants { get; set; }
        public PropertyStatus PropertyStatus { get; set; }
        public PropertyType PropertyType { get; set; }
        public PropertyClassification PropertyClassification { get; set; }
        public ICollection<SpecialRooms> SpecialRooms { get; set; }
        public decimal SquareFootage { get; set; }
        public PersonRecord ListedBy { get; set; }
        public ICollection<Anemity> Anemities{ get; set; }
        public DateTime OpenFrom { get; set; }
        public DateTime ExpiresOn { get; set; }

    }

}