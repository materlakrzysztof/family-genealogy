using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace WebApp.Infrastructure
{
    public class GenealogyContext : DbContext
    {
        public GenealogyContext(DbContextOptions<GenealogyContext> options) : base(options)
        {
        }
    }
}
