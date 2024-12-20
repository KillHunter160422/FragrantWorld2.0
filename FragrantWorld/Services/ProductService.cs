using FragrantWorld.Data;
using FragrantWorld.Interface;
using FragrantWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Services
{
    public class ProductService : IProductService
    {
        private readonly FW_ShopDbContext _context;

        public ProductService(FW_ShopDbContext context)
        {
            _context = context;
        }
        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }
    }
}
