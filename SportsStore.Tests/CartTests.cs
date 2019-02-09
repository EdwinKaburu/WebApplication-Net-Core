using System;
using System.Collections.Generic;
using System.Text;
using SportsStore.Models;
using Xunit;
using System.Linq;

namespace SportsStore.Tests
{
    public  class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            //Arrange - create some test products
            //Product p1 = new Product { ProductID = 1, Name = "P1" };
            //Product p2 = new Product { ProductID = 2, Name = "P2" };

            MusicProduct p1 = new MusicProduct
            {
                MusicID = 1,
                MusicName = "Names",
                MusicPictureID = 3,
                GenreID = 2,
                ArtistID = 1,
                MusicDataID = 2
            };

            MusicProduct p2 = new MusicProduct
            {
                MusicID = 8,
                MusicName = "Names1",
                MusicPictureID = 2,
                GenreID = 4,
                ArtistID = 5,
                MusicDataID = 6
            };
            //Arrange - create a new Cart
            Cart target = new Cart();

            //Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            //This line in the book reads  -- >    CartLine[] results = target.Lines.ToArray();
            CartLine[] results = target.Lines.ToArray();

            //Assert
            Assert.Equal(2, results.Count());
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);
            
        }
        [Fact]
        public void Can_Add_Quantity_For_Existing()
        {
            //Arrange - create some Test Products
            MusicProduct p1 = new MusicProduct
            {
                MusicID = 1,
                MusicName = "Names",
                MusicPictureID = 3,
                GenreID = 2,
                ArtistID = 1,
                MusicDataID = 2
            };

            MusicProduct p2 = new MusicProduct
            {
                MusicID = 8,
                MusicName = "Names1",
                MusicPictureID = 2,
                GenreID = 4,
                ArtistID = 5,
                MusicDataID = 6
            };
            //Arrange - Create a new Cart
            Cart target = new Cart();

            //Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);
            CartLine[] results = target.Lines.OrderBy(c => c.Product.MusicID).ToArray();

            //Assert
            Assert.Equal(2, results.Length);
            Assert.Equal(11, results[0].Quantity);
            Assert.Equal(1, results[1].Quantity);
        }
    }
}
