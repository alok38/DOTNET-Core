using WebApplication1.DataAccessLayer;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
       public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
       public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
        public bool Remove(int id)

        {
            var p = GetProduct(id);
           _context.Products.Remove(p);
            _context.SaveChanges();
            return true;
        }
       public bool Update(Product product)
        {
            var p = GetProduct(product.Id);
            p.Price = product.Price;
            p.Category = product.Category;
            p.Name = product.Name;
            
            _context.SaveChanges();
            return true;
        }

    }
}
