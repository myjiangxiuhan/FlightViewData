using Models;

namespace ViewModels
{
    public class FlightViewModel
    {
        public string OrigAirportName { get; set; }
        public string DestAirportName { get; set; }
        public int[] OrigAirportCoord { get; set; }
        public int[] DestAirportCoord { get; set; }
        public int ComeCount { get; set; }
    }
}