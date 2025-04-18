using Microsoft.EntityFrameworkCore;

namespace WebApp.Infrastructure
{
    public class GenealogyContext : DbContext
    {
        public GenealogyContext(DbContextOptions<GenealogyContext> options) : base(options)
        {
        }
    }
}
