using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Room : Entity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public RoomType Type { get; set; }
    }
}
