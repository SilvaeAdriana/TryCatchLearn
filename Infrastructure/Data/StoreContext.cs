
using Microsoft.EntityFrameworkCore;
//criado itemgroup no .csproj respectivo
// using skinet.Entities;
using Core.Entities;

// namespace skinet.Data
namespace Infrastructure.Data
{

    //clicar em StoreContext para aparecer a lampadinha e as opcoes de construtores
    public class StoreContext : DbContext
    {
        //consturtor
        //options se refere a connection string
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products {get; set; }  //set de dados chamado Products de Product.cs
    }
}