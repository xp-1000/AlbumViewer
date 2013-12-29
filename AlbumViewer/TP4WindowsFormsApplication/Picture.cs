using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumViewer
{
    public class Picture
    {
        public String path { get; set; } 
        public String comment { get; set; }
        public Categories category { get; set; }
        public Ranks rank { get; set; }
  
        public Picture()
        {
            this.category = Categories.None;
            this.rank = Ranks.Minor;   
        }

        public Picture(String path, String comment, Categories category)
        {
            this.path = path;
            this.comment = comment;
            this.category = category;            
        }
    }
}
