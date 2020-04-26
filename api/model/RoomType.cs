using System.ComponentModel.DataAnnotations;

namespace model
{
    public class RoomType : Entity
    {
        [Required]
        public string Type { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
