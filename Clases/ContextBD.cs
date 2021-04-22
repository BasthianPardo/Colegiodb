using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Colegiodb.Clases
{
    public partial class ContextBD : DbContext
    {
        public ContextBD()
            : base("name=ContextBD")
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Profesore> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Estudiantes)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesore>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesore>()
                .HasMany(e => e.Cursos)
                .WithRequired(e => e.Profesore)
                .WillCascadeOnDelete(false);
        }
    }
}
