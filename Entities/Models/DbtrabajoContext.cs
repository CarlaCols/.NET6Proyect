using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

public partial class DbtrabajoContext : DbContext
{
    public DbtrabajoContext()
    {
    }

    public DbtrabajoContext(DbContextOptions<DbtrabajoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }
    public virtual DbSet<Empleado> Empleados { get; set; }
    public virtual DbSet<Empresa> Empresas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=COLS; Database=DBTrabajo; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cargo");

            entity.Property(e => e.Decripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idempleado).HasColumnName("IDEmpleado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Empleado");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Empresa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
