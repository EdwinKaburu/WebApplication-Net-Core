using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<MusicProduct> MusicProducts{ get; }
        IQueryable<MusicPicture> MusicPictures { get; }

        void SaveProduct(MusicProduct product);

        MusicProduct DeleteProduct(int productID);
    }
}
 