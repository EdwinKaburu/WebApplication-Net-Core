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

        //  public IQueryable<MusicData> Products => context.MusicDatas;
    }
}
