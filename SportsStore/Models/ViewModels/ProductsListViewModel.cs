using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {

        /*
         * Get a list of Music Product 
         * !!!  Music Picture not required since MusicPicture is defined in the Music Product Class , as such you can access the indvidual 
         * picture by calling the property its-self;
         */

        public IEnumerable<MusicProduct> Products { get; set; }
        public IEnumerable<MusicPicture> Pictures { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
