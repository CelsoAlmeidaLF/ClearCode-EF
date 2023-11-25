using Microsoft.EntityFrameworkCore;
using Systekna.Core.Model;

namespace Systekna.Infrasctruture
{
    public class DbFinanceiroContext()
        : DbContext()
    {
        public DbSet<ModelDespesa> TbDespesa { get; set; }

        //public DbSet<ModelPagamento> TbPagamento { get; set; }
        //public DbSet<ModelRequisições> TbRequisições { get; set; }
        //public DbSet<ModelCompras> TbCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("string connection....");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}