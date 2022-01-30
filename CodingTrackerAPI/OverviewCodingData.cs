using System.ComponentModel.DataAnnotations;

namespace CodingTrackerAPI
{
    public class OverviewCodingData
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Cooments { get; set; } = string.Empty;

        public int CodingTypeId { get; set; }

        public CodingType? CodingType { get; set; }
    }
}
