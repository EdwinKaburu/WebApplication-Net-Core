using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
    * This is a class defined for the  "   UserDb Table in the Database ",
    * Below are the Properties that are associated with the Table itseld
    */
    [Table("UserDb")]
    public class UserDb
    {
        /*
         * This is the Constructor of the UserDb in which you have a HashSet of UserPlayList, since the user can
         * have multiple.
         */
        public UserDb()
        {
            UserPlayLists = new HashSet<UserPlayList>();
        }
        //This defines the UserID as the Primary Key , based on the Database itself
        [Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        public int? GenreID { get; set; }

        public virtual GenreCategory GenreCategory { get; set; }

        public virtual ICollection<UserPlayList> UserPlayLists { get; set; }
    }
}
