

using Microsoft.AspNetCore.Mvc;

namespace skinet.Controllers
{

    [ApiController]//nome padrão,sempre esse
    [Route("skinet/[controller]")]//caminho , a parte do controller é a obrigatória
    public class ProductsController:ControllerBase
    {
        
        //endpoint
        [HttpGet]
        public string GetProducts()
        {
            return "this will be a  list of products here";
        }


        [HttpGet("{id}")]// pega pelo id do produto
        public string GetProduct(int id)
        {
            return "this will be a product";
        }
    }
}