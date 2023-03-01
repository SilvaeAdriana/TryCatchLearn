
using Microsoft.EntityFrameworkCore;
using skinet.Entities;

namespace skinet.Data
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