using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    //public class Cart
    //{
    //    private List<UserPlayList> lineCollection = new List<UserPlayList>();
    //    public virtual void AddItem(MusicProduct music, int quantity)
    //    {
    //        UserPlayList line = lineCollection.Where(p => p.MusicProduct.MusicID == music.MusicID).FirstOrDefault();
    //        if(line == null)
    //        {
    //            lineCollection.Add(new UserPlayList
    //            {
    //                MusicProduct = music,
    //                Quantity = quantity,
    //                UserID = lineCollection.Count + 1

    //            });
    //        }
    //        else
    //        {
    //            line.Quantity += quantity;
    //        }
    //    }

    //    public virtual void RemoveLine(MusicProduct product) => lineCollection.RemoveAll(l => l.MusicProduct.MusicID == product.MusicID);
    //    public virtual decimal ComputeTotalValue() => lineCollection.Sum(e => Convert.ToDecimal(e.MusicProduct.Price) * Convert.ToDecimal(e.Quantity));
    //    public virtual void Clear() => lineCollection.Clear();
    //    public virtual IEnumerable<UserPlayList> lines => lineCollection;
    //}
    public class CartLine
    {
        public int CartLineID { get; set; }
        public MusicProduct Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(MusicProduct product, int quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.MusicID == product.MusicID).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(MusicProduct product) => lineCollection.RemoveAll(l => l.Product.MusicID == product.MusicID);
        public virtual decimal ComputeTotalValue() => lineCollection.Sum(e => Convert.ToDecimal(e.Product.Price) * Convert.ToDecimal(e.Quantity));
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }
}
