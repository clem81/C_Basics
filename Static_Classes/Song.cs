using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        //static means it can't be changed outside the class
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //THis calls and increments everytime a new song is created and holds info to do with the class, not about the specific objects
            songCount++;

        }
    }
}
