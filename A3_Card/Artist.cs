using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Card
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DebutAlbum { get; set; }
        public string Img { get; set; }
        public int GroupId { get; set; } // foreign key

        public override bool Equals(object obj)
        {
            if (obj is Artist other)
            {
                return Id == other.Id &&
                       Name == other.Name &&
                       Age == other.Age &&
                       DebutAlbum == other.DebutAlbum &&
                       Img == other.Img &&
                       GroupId == other.GroupId;
            }
            return false;
        }


    }
}
