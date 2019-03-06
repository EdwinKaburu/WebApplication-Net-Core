using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class DatabaseContext:DbContext
    {
        /**
         * This class is essential the Migration , on which linking between the database and the class is performed
         */
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {

        }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistPicture> ArtistPictures { get; set; }
        public virtual DbSet<GenreCategory> GenreCategories { get; set; }
        public virtual DbSet<MusicData> MusicDatas { get; set; }
        public virtual DbSet<MusicPicture> MusicPictures { get; set; }
        public virtual DbSet<MusicProduct> MusicProducts { get; set; }
        public virtual DbSet<UserDb> UserDbs { get; set; }
        public virtual DbSet<UserPlayList> UserPlayLists { get; set; }
      //  public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
               .Property(e => e.ArtistName)
               .IsFixedLength();

            modelBuilder.Entity<Artist>()
                .Property(e => e.ArtistDescription)
                .IsUnicode(false);

            modelBuilder.Entity<GenreCategory>()
                .Property(e => e.GenreName)
                .IsFixedLength();

            modelBuilder.Entity<GenreCategory>()
                .Property(e => e.GenreDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MusicProduct>()
                .Property(e => e.MusicName)
                .IsFixedLength();

            modelBuilder.Entity<UserDb>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<UserDb>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserDb>()
                .Property(e => e.UserEmail)
                .IsFixedLength();

            modelBuilder.Entity<UserPlayList>()
                .Property(e => e.PlaylistName)
                .IsFixedLength();
        }
    }
}
