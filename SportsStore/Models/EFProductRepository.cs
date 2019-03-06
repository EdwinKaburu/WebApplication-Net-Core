using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private DatabaseContext context;

        public EFProductRepository(DatabaseContext ctx)
        {
            context = ctx;
        }

        public IQueryable<MusicProduct> MusicProducts => context.MusicProducts;

        public IQueryable<MusicPicture> MusicPictures => context.MusicPictures;

        public void SaveProduct(MusicProduct product)
        {
            if(product.MusicID == 0)
            {
                context.MusicProducts.Add(product);
            }
            else
            {
                MusicProduct dbEntry = context.MusicProducts.FirstOrDefault(p => p.MusicID == product.MusicID);
                if(dbEntry != null)
                {
                    dbEntry.MusicName = product.MusicName;
                    dbEntry.Artist.ArtistDescription = product.Artist.ArtistDescription;
                    dbEntry.Price = product.Price;
                    dbEntry.GenreCategory.GenreDescription = dbEntry.GenreCategory.GenreDescription;
                }
            }
            context.SaveChanges(); 
        }
        public MusicProduct DeleteProduct(int productID)
        {
            MusicProduct dbEntry = context.MusicProducts.FirstOrDefault(p => p.MusicID == productID);
            if(dbEntry != null)
            {
                context.MusicProducts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
        //  public IQueryable<MusicData> Products => context.MusicDatas;
    }
}
