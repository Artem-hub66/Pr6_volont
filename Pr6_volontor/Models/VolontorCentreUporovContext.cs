using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pr6_volontor.Models;

public partial class VolontorCentreUporovContext : DbContext
{
    public VolontorCentreUporovContext()
    {
    }

    public VolontorCentreUporovContext(DbContextOptions<VolontorCentreUporovContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<RegistVolont> RegistVolonts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusesEvent> StatusesEvents { get; set; }

    public virtual DbSet<StatusesRegist> StatusesRegists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=volontor_centre_uporov;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_categories_id");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameCategor).HasColumnName("name_categor");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_events_id");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountUser).HasColumnName("count_user");
            entity.Property(e => e.DateEvent).HasColumnName("date_event");
            entity.Property(e => e.IdCategorie).HasColumnName("id_categorie");
            entity.Property(e => e.IdStatusEvent).HasColumnName("id_status_event");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.NameEvent).HasColumnName("name_event");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdCategorie)
                .HasConstraintName("fk_events_to_categories");

            entity.HasOne(d => d.IdStatusEventNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdStatusEvent)
                .HasConstraintName("fk_events_to_statuses_events");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_events_to_users");
        });

        modelBuilder.Entity<RegistVolont>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_regist_volonts_id");

            entity.ToTable("regist_volonts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRegist).HasColumnName("date_regist");
            entity.Property(e => e.IdEvent).HasColumnName("id_event");
            entity.Property(e => e.IdStatusRegist).HasColumnName("id_status_regist");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdEventNavigation).WithMany(p => p.RegistVolonts)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("fk_regist_volonts_to_events");

            entity.HasOne(d => d.IdStatusRegistNavigation).WithMany(p => p.RegistVolonts)
                .HasForeignKey(d => d.IdStatusRegist)
                .HasConstraintName("fk_regist_volonts_to_statuses_regist");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.RegistVolonts)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_regist_volonts_to_users");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles_id");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<StatusesEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_statuses_events_id");

            entity.ToTable("statuses_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameStatus).HasColumnName("name_status");
        });

        modelBuilder.Entity<StatusesRegist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_statuses_regist_id");

            entity.ToTable("statuses_regist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameStatus).HasColumnName("name_status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users_id");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Pass).HasColumnName("pass");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
