using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CvHandlerForm.Models
{
    public partial class CVDBContext : DbContext
    {
        public CVDBContext()
        {
        }

        public CVDBContext(DbContextOptions<CVDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Postulant> Postulants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Datasource=C:\\Users\\USER\\Documents\\CsharpProjects\\CvHandler\\CvHandlerForm\\DB\\CvHandlerDb.sqlite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postulant>(entity =>
            {
                entity.ToTable("Postulant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
