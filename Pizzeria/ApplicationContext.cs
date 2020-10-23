using Microsoft.EntityFrameworkCore;

namespace Pizzeria
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options) { }
    }
}
