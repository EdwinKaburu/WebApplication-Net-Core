using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
  * This is a class defined for the  "  MusicProduct Table in the Database ",
  * Below are the Properties that are associated with the Table itseld
  */
    [Table("MusicProduct")]
    public class MusicProduct
    {
        /*
        * This is the Constructor of the Music Product in which you have a HashSet of UserPlayList, since this 
        * specific music can be in multiple playlist
        */
        public MusicProduct()
        {
            UserPlayLists = new HashSet<UserPlayList>();
        }
        //This defines the MusicProduct as the Primary Key , based on the Database itself
        [Key]
        public int MusicID { get; set; }

        public string MusicName { get; set; }

        public int? MusicPictureID { get; set; } 

        public int? GenreID { get; set; } 

        public int? ArtistID { get; set; }

        public int? MusicDataID { get; set; }

        public decimal? Price { get; set; } // To be Changed Later On

        public virtual Artist Artist { get; set; }

        public virtual GenreCategory GenreCategory { get; set; }

        public virtual MusicData MusicData { get; set; }

        public virtual MusicPicture MusicPicture { get; set; }

        public virtual ICollection<UserPlayList> UserPlayLists { get; set; }
    }
}
