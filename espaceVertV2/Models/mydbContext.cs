using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace espaceVertV2.Models
{
    public partial class mydbContext : DbContext
    {
        public mydbContext()
        {
        }

        public mydbContext(DbContextOptions<mydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Composée> Composées { get; set; }
        public virtual DbSet<Contient> Contients { get; set; }
        public virtual DbSet<Faire> Faires { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Passe> Passes { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=mydb;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Idadmin)
                    .HasName("PRIMARY");

                entity.ToTable("admin");

                entity.Property(e => e.Idadmin)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("idadmin");

                entity.Property(e => e.Identifiant)
                    .HasMaxLength(45)
                    .HasColumnName("identifiant");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Idclient)
                    .HasName("PRIMARY");

                entity.ToTable("client");

                entity.Property(e => e.Idclient)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("idclient");

                entity.Property(e => e.Adresseclient)
                    .HasMaxLength(45)
                    .HasColumnName("adresseclient");

                entity.Property(e => e.Codepostalclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("codepostalclient");

                entity.Property(e => e.Emailclient)
                    .HasMaxLength(45)
                    .HasColumnName("emailclient");

                entity.Property(e => e.Nomclient)
                    .HasMaxLength(45)
                    .HasColumnName("nomclient");

                entity.Property(e => e.Prenomclient)
                    .HasMaxLength(45)
                    .HasColumnName("prenomclient");

                entity.Property(e => e.Villeclient)
                    .HasMaxLength(45)
                    .HasColumnName("villeclient");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => new { e.Idcommande, e.ClientIdclient, e.PasseClientIdclient })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("commande");

                entity.HasIndex(e => e.PasseClientIdclient, "fk_commande_passe1_idx");

                entity.Property(e => e.Idcommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcommande");

                entity.Property(e => e.ClientIdclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_idclient");

                entity.Property(e => e.PasseClientIdclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("passe_client_idclient");

                entity.Property(e => e.Datecommande)
                    .HasMaxLength(45)
                    .HasColumnName("datecommande");

                entity.Property(e => e.Delaicommande)
                    .HasColumnType("date")
                    .HasColumnName("delaicommande");

                entity.Property(e => e.Prixdecommande)
                    .HasMaxLength(45)
                    .HasColumnName("prixdecommande");
            });

            modelBuilder.Entity<Composée>(entity =>
            {
                entity.HasKey(e => new { e.CommandeIdcommande, e.CommandeClientIdclient, e.ProduitIdproduit })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("composée");

                entity.HasIndex(e => new { e.CommandeIdcommande, e.CommandeClientIdclient }, "fk_composée_commande1_idx");

                entity.HasIndex(e => e.ProduitIdproduit, "fk_composée_produit1_idx");

                entity.Property(e => e.CommandeIdcommande)
                    .HasColumnType("int(11)")
                    .HasColumnName("commande_idcommande");

                entity.Property(e => e.CommandeClientIdclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("commande_client_idclient");

                entity.Property(e => e.ProduitIdproduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("produit_idproduit");
            });

            modelBuilder.Entity<Contient>(entity =>
            {
                entity.HasKey(e => new { e.LocationIdlocation, e.LocationFaireClientIdclient, e.ProduitIdproduit })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("contient");

                entity.HasIndex(e => e.ProduitIdproduit, "fk_contient_produit1_idx");

                entity.Property(e => e.LocationIdlocation)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_idlocation");

                entity.Property(e => e.LocationFaireClientIdclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_faire_client_idclient");

                entity.Property(e => e.ProduitIdproduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("produit_idproduit");
            });

            modelBuilder.Entity<Faire>(entity =>
            {
                entity.HasKey(e => e.ClientIdclient)
                    .HasName("PRIMARY");

                entity.ToTable("faire");

                entity.Property(e => e.ClientIdclient)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("client_idclient");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => new { e.Idlocation, e.FaireClientIdclient })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("location");

                entity.HasIndex(e => e.FaireClientIdclient, "fk_location_faire1_idx");

                entity.Property(e => e.Idlocation)
                    .HasColumnType("int(11)")
                    .HasColumnName("idlocation");

                entity.Property(e => e.FaireClientIdclient)
                    .HasColumnType("int(11)")
                    .HasColumnName("faire_client_idclient");

                entity.Property(e => e.Datedebutlocation)
                    .HasMaxLength(45)
                    .HasColumnName("datedebutlocation");

                entity.Property(e => e.Datefinlocation)
                    .HasMaxLength(45)
                    .HasColumnName("datefinlocation");

                entity.Property(e => e.Prixlocation)
                    .HasMaxLength(45)
                    .HasColumnName("prixlocation");
            });

            modelBuilder.Entity<Passe>(entity =>
            {
                entity.HasKey(e => e.ClientIdclient)
                    .HasName("PRIMARY");

                entity.ToTable("passe");

                entity.Property(e => e.ClientIdclient)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("client_idclient");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.Idproduit)
                    .HasName("PRIMARY");

                entity.ToTable("produit");

                entity.Property(e => e.Idproduit)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("idproduit");

                entity.Property(e => e.Nomproduit)
                    .HasMaxLength(45)
                    .HasColumnName("nomproduit");

                entity.Property(e => e.Quantitelocationproduit)
                    .HasMaxLength(45)
                    .HasColumnName("quantitelocationproduit");

                entity.Property(e => e.Quantitestockproduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantitestockproduit");

                entity.Property(e => e.Quantitetotalproduit)
                    .HasMaxLength(45)
                    .HasColumnName("quantitetotalproduit");

                entity.Property(e => e.Typeproduit)
                    .HasMaxLength(45)
                    .HasColumnName("typeproduit");

                entity.Property(e => e.Valeurproduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("valeurproduit");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
