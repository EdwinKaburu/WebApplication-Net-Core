using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsStore.Models
{
    /*
 * This is a class defined for the  "  MusicData Table in the Database ",
 * Below are the Properties that are associated with the Table itseld
 */
    [Table("MusicData")]
    public class MusicData
    {
        /*
       * This is the Constructor of the Music Data in which you have a HashSet of MusicProduct
       */
        public MusicData()
        {
            MusicProducts = new HashSet<MusicProduct>();
        }

        public int MusicDataID { get; set; }

        public byte[] MusicDatas { get; set; }

        public virtual ICollection<MusicProduct> MusicProducts { get; set; }
    }
}
