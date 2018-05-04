using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaly
{
   public class Song
    {
       
        public string Songtype { get; set; }
        public string SongPath { get; set; }
        public Song() { }
        public Song(string Songtype, string SongPath) 
        {
            this.SongPath = SongPath;
            this.Songtype = Songtype;
        }
    }

}
