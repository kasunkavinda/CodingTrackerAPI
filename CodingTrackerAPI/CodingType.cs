using System.ComponentModel.DataAnnotations;

namespace CodingTrackerAPI
{
    public class CodingType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string CodingName { get; set; } = string.Empty;
    }
}
