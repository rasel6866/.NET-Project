using System;
using System.Collections.Generic;
using DAL.EF.Tables;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF;

public partial class DbBloodContext : DbContext
{
    public DbBloodContext()
    {
    }

    public DbBloodContext(DbContextOptions<DbBloodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BloodRequest> BloodRequests { get; set; }

    public virtual DbSet<BloodStock> BloodStocks { get; set; }

    public virtual DbSet<Donor> Donors { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DbBlood;TrustServerCertificate=True;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BloodRequest>(entity =>
        {
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hospital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BloodStock>(entity =>
        {
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Donor>(entity =>
        {
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastDonationDate).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uid)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

 

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
