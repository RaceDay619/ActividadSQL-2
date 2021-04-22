using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ActividadSQL.Clases
{
    public partial class BDContext : DbContext
    {
        public BDContext()
            : base("name=BDContext")
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Profesores> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>()
                .Property(e => e.nombreAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .Property(e => e.NombreCurso)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Alumnos)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesores>()
                .Property(e => e.NombreProfesor)
                .IsUnicode(false);

            modelBuilder.Entity<Profesores>()
                .HasMany(e => e.Curso)
                .WithRequired(e => e.Profesores)
                .WillCascadeOnDelete(false);
        }
    }
}
