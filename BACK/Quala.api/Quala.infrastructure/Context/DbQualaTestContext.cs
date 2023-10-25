using Microsoft.EntityFrameworkCore;
using Quala.domain.Entities.Models;

#nullable disable

namespace Quala.infrastructure.Context
{
    public partial class DbQualaTestContext : DbContext
    {
        public DbQualaTestContext()
        {
        }

        public DbQualaTestContext(DbContextOptions<DbQualaTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Monedum> Moneda { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= DESKTOP-TN31B2J;Database=DbQualaTest;User Id=qualatest; Password=quala123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Monedum>(entity =>
            {
                entity.ToTable("moneda", "sucursales");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.ToTable("sucursal", "sucursales");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Fechacreacion)
                    .HasColumnType("date")
                    .HasColumnName("fechacreacion");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identificacion");

                entity.Property(e => e.MonedaId).HasColumnName("monedaId");

                entity.Property(e => e.Estado).HasColumnType("estado");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.Sucursals)
                    .HasForeignKey(d => d.MonedaId)
                    .HasConstraintName("FK_sucursal_moneda");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
