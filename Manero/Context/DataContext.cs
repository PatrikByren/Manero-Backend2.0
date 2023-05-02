using Microsoft.EntityFrameworkCore;

namespace Manero.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
