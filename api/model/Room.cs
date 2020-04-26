using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace model
{
    public class Room : Entity
    {
        public int Number { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual RoomType Type { get; set; }
    }
}
