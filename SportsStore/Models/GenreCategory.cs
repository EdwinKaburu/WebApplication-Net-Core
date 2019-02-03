using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{

    /*
 * This is a class defined for the  "  GenereCategory Table in the Database ",
 * Below are the Properties that are associated with the Table itseld
 */
    [Table("GenreCategory")]
    public class GenreCategory
    {
        /*
      * This is the Constructor of the GenreCategory in which you have a HashSet of  MusicProduct and UserDb  --->
      * ----( -- Based on which Genre the User Prefer!!!)
      */
        public GenreCategory()
        {
            MusicProducts = new HashSet<MusicProduct>();
            UserDbs = new HashSet<UserDb>();
        }
        [Key]
        public int GenreID { get; set; }

        public string GenreName { get; set; }

        public string GenreDescription { get; set; }

        public virtual ICollection<MusicProduct> MusicProducts { get; set; }

        public virtual ICollection<UserDb> UserDbs { get; set; }
    }
}
