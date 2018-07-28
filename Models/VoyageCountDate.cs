using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class VoyageDate
    {
        [Key]
        public int Id { get; set; }
        public int OneId { get; set; }
        public DateTime Date { get; set; }
        public int GoCount { get; set; }
        public int RetCount { get; set; }
        public VoyageOne AirportFlightOne { get; set; }
    }
}