using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationTest.Models
{
    public class Station
    {


    
        public int StationID { get; set; }

        public short TripRegion_Code { get; set; }

        public short TripOffice_Code { get; set; }

        public string? OfficeNameA { get; set; }

        public string? OfficeNameE { get; set; }

        public string? OfficeAddressAr { get; set; }

        public string? OfficeAddressEn { get; set; }

        public string? OfficeTel { get; set; }

        public short TripRegion_Order { get; set; }

        public string? TripRegion_NameA { get; set; }

        public string? TripRegion_NameE { get; set; }

        public string? Latitude { get; set; }

        public string? Longitude { get; set; }

       [NotMapped]
        public string? Auth { get; set; }
    }
  
}
