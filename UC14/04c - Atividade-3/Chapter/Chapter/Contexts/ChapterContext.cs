using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext 
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-FVVTLIQM\\SQLEXPRESS ; initial catalog = Chapter; Integrad Security = true");
            }
        }


        public DbSet<Livro> Livros { get; set; }
    }
}
