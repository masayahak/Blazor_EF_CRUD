using Blazor_EF_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_EF_CRUD.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public required DbSet<Movie> Movies { get; set; }

    }
}
