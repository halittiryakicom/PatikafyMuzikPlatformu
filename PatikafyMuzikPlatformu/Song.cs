using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikafyMuzikPlatformu
{
    public class Song : IComparable<Song>
    {
        public string FullName { get; set; }
        public string MusicGenre { get; set; }
        public int Year { get; set; }
        public int Sales { get; set; }


        public int CompareTo(Song? other)
        {
            throw new NotImplementedException();
        }
    }
}
