using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pruebaAdmision.Models
{
    public partial class PruebaAdmisionContext : DbContext
    {
        public PruebaAdmisionContext()
        {
        }

        public PruebaAdmisionContext(DbContextOptions<PruebaAdmisionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=server1.middlewarehn.com,48030;Database=PruebaAdmision;User Id=prueba;Password=ZxCGon6rG4AgEa46x7Pw;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__DEPARTAM__52E77BE0BDA2806E");

                entity.ToTable("DEPARTAMENTOS");

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasColumnName("REFERENCIA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__922CA269F8B8AE7D");

                entity.ToTable("EMPLEADOS");

                entity.Property(e => e.IdEmpleado).HasColumnName("ID_EMPLEADO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("FECHA_NACIMIENTO")
                    .HasColumnType("date");

                entity.Property(e => e.GeneroSexo)
                    .IsRequired()
                    .HasColumnName("GENERO_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLEADOS__ID_DE__25869641");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
