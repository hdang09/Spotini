using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class SpotiniDBContext : DbContext
    {
        public SpotiniDBContext()
        {
        }

        public SpotiniDBContext(DbContextOptions<SpotiniDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<FavoriteList> FavoriteLists { get; set; }
        public virtual DbSet<Music> Musics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=SpotiniDB;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.FullName)
                    .HasMaxLength(500)
                    .HasColumnName("fullName");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(500)
                    .HasColumnName("role");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(500)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist");

                entity.Property(e => e.ArtistId).HasColumnName("artistId");

                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .HasColumnName("country");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FavoriteList>(entity =>
            {
                entity.ToTable("FavoriteList");

                entity.Property(e => e.FavoriteListId).HasColumnName("favoriteListId");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.MusicId).HasColumnName("musicId");
            });

            modelBuilder.Entity<Music>(entity =>
            {
                entity.ToTable("Music");

                entity.Property(e => e.MusicId).HasColumnName("musicId");

                entity.Property(e => e.ArtistId)
                    .HasMaxLength(500)
                    .HasColumnName("artistId");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("releaseDate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
