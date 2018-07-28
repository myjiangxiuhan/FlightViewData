using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("airport_flight_one")]
    public class AirportFlightOne
    {
        [Key]
        public int? Id { get; set; }
        public string OrigAirportSzm { get; set; }
        public string DestAirportSzm { get; set; }
        public Airport OrigAirport { get; set; }
        public Airport DestAirport { get; set; }
    }
}