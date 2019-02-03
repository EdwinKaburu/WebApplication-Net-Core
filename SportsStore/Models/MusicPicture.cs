using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
 * This is a class defined for the  "  MusicPicture Table in the Database ",
 * Below are the Properties that are associated with the Table itseld
 */
    [Table("MusicPicture")]
    public class MusicPicture
    {
        /*
       * This is the Constructor of the Music Picture in which you have a HashSet of MusicProduct
       */
        public MusicPicture()
        {
            MusicProducts = new HashSet<MusicProduct>();
        }
        //This defines the MusicPictureID as the Primary Key , based on the Database itself
        [Key]
        public int MusicPictureID { get; set; }

        public byte[] PictureFirst { get; set; }

        public byte[] PictureTwo { get; set; }

        public virtual ICollection<MusicProduct> MusicProducts { get; set; }
    }
}
