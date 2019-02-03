using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
* This is a class defined for the  " Artist Picture Table in the Database ",
* Below are the Properties that are associated with the Table itseld
*/
    [Table("ArtistPicture")]
    public class ArtistPicture
    {
        /*
     * This is the Constructor of the AristPicture in which you have a HashSet of  Artist
     */
        public ArtistPicture()
        {
            Artists = new HashSet<Artist>();
        }
        public int ArtistPictureID { get; set; }

        public byte[] PictureFirst { get; set; }

        public byte[] PictureTwo { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
