using Intranet.Models;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Data
{
    public class BancoContext : DbContext
    {
        public DbSet<ContatoModel> Contatos{ get; set; }
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }
    }
}
