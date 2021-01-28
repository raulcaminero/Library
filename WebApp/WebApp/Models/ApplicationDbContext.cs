using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public virtual DbSet<Usuario> usuarios { get; set; }
		public virtual DbSet<Estado> Estado { get; set; }
		public virtual DbSet<Book> Book { get; set; }
		public virtual DbSet<BookPages> BookPages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Estado>(entity =>
			{
				entity.Property(e => e.EstadoId)
					.HasColumnName("Estado_Id")
					.HasMaxLength(1)
					.IsUnicode(false)
					.IsFixedLength();

				entity.Property(e => e.EstadoNombre)
					.IsRequired()
					.HasColumnName("Estado_Nombre")
					.HasMaxLength(10)
					.IsFixedLength();
			});

			modelBuilder.Entity<Usuario>(entity =>
			{
				entity.Property(e => e.EstadoId)
					.IsRequired()
					.HasColumnName("Estado_Id")
					.HasMaxLength(1)
					.IsUnicode(false)
					.IsFixedLength();
			});
		}
	}

}
