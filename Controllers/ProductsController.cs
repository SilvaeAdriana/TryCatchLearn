

using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// using skinet.Data;
// using skinet.Entities;

namespace skinet.Controllers
{

    [ApiController]//nome padrão,sempre esse
    [Route("skinet/[controller]")]//caminho , a parte do controller é a obrigatória



    public class ProductsController: ControllerBase
    {






        //endpoint
         //NÃO FUNCIONA O POSTMAN DEIXAR HABILITADO  --Não admite dois [httpget] simultâneos??
        // [HttpGet]
        // public string GetProducts()
        // {
        //     return "this will be a  list of products here";
        // }


        //acesso ao db       
        private readonly StoreContext _context;//ele conseguiu criar isso por atalho
        public ProductsController(StoreContext context)//dependecy injection (isso aqui é um construtor ..do dbcontext??foi chamado pelo atalho da lampada)
        //injecao de serviço em uma classe: o serviço é o DbContext(StoreContext)
        {   //_context se refere a context da linha 18;poderia ser this.context
            _context = context;
        }

        //retornando uma lista de produtos
        //aqui ele ja conversa com os dados inseridos no sqlite
         [HttpGet]
         //public ActionResult<List<Product>>> GetProductsList()sem awat/async
        public async Task<ActionResult<List<Product>>> GetProductsList()
        {
            var products = await  _context.Products.ToListAsync();
            return products;
        }


        [HttpGet("{id}")]// pega pelo id do produto
        public string GetProduct(int id)
        {
            return "this will be a product";
        }
    }
}