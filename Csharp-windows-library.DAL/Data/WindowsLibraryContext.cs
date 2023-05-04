using System;
using System.Collections.Generic;
using Csharp_windows_library.Models;
using Microsoft.EntityFrameworkCore;

namespace Csharp_windows_library.DAL.Data;

public partial class WindowsLibraryContext : DbContext
{
    public WindowsLibraryContext()
    {
    }

    public WindowsLibraryContext(DbContextOptions<WindowsLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<OwnedBook> OwnedBooks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; Database = WindowsLibrary; encrypt = false; Trusted_Connection = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC07A4C865F3");

            entity.Property(e => e.AuthorFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BookName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OwnedBook>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.Book).WithMany()
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__OwnedBook__BookI__3A81B327");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__OwnedBook__UserI__398D8EEE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0726587808");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
