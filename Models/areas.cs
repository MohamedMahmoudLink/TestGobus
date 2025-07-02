using System.ComponentModel.DataAnnotations;

namespace StationTest.Models
{
    public class areas
    {

        public int IDArea { get; set; }
        public int IDCity { get; set; }
        public string AreaNameAr { get; set; }
        public string AreaNameEn { get; set; }
        public bool AreaServed { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
    }
}
