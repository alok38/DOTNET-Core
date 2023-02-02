using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductAPIController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_repository.GetAllProducts());

        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            return Ok(_repository.Add(product));
           
        }
        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetProduct(int id)

        {
            Product item = _repository.GetProduct(id);
            if (item == null)
            {
                NotFound();
            }

            return Ok(item);
        }         
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            product.Id = id;
            if (!_repository.Update(product))
            {
                NotFound();
            }
            return Ok(_repository.Update(product));

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)

        {
            _repository.Remove(id);
            return NoContent();
        }
    }
}





















//var createdProduct = _repository.Add(product);
//return CreatedAtRoute("GetProduct", new { id = createdProduct.ToString() }, createdProduct);