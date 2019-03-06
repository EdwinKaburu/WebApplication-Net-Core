using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SportsStore.Models
{
    /*
* This is a class defined for the  " Artist  Table in the Database ",
* Below are the Properties that are associated with the Table itseld
*/
    [Table("Artist")]
    public class Artist
    {
        /*
     * This is the Constructor of the Artist in which you have a HashSet of MusicProduct
     */
        public Artist()
        {
            MusicProducts = new HashSet<MusicProduct>();
        }
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }

        [Required(ErrorMessage = "Please Enter an Description")]
        public string ArtistDescription { get; set; }

        public int? ArtistPictureID { get; set; }

        public virtual ArtistPicture ArtistPicture { get; set; }

        public virtual ICollection<MusicProduct> MusicProducts { get; set; }
    }
}
