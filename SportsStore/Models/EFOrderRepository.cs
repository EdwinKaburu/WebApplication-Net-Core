using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SportsStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private DatabaseContext context;

        public EFOrderRepository(DatabaseContext ctx)
        {
            context = ctx;
        }
        //public IQueryable<UserPlayList> Orders => context.Orders.Include(o => o.Lines)
        //    .ThenInclude(l => l.Product);

        public IQueryable<UserDb> Orders => context.UserDbs
           .Include(o => o.UserPlayLists)
           .ThenInclude(l => l.MusicProduct);

        public void SaveOrder(UserDb order)
        {
            context.AttachRange(order.UserPlayLists.Select(l => l.MusicProduct));
            if (order.UserID== 0)
            {
                context.UserDbs.Add(order);
            }
            context.SaveChanges();
        }
    }
}
