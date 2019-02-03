using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
     * This is a class defined for the  "   User PlayList Table in the Database ",
     * Below are the Properties that are associated with the Table itseld
     */
    [Table("UserPlayList")]
    public class UserPlayList
    {
        //This defines the PlaylistID as the Primary Key , based on the Database itself
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaylistID { get; set; }

        public string PlaylistName { get; set; }

        public int? UserID { get; set; }

        public int? MusicID { get; set; } 

        public virtual MusicProduct MusicProduct { get; set; }

        public virtual UserDb UserDb { get; set; }
    }
}
