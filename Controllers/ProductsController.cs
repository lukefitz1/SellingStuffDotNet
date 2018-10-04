using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SellingStuffDotNet.Controllers.Resources;
using SellingStuffDotNet.Models;
using SellingStuffDotNet.Persistence;

namespace SellingStuffDotNet.Controllers
{
    [Route("/api/products")]
    public class ProductsController : Controller
    {
        private readonly SellingStuffDbContext context;
        private readonly IMapper mapper;

        public ProductsController(SellingStuffDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> GetProducts()
        {
            var products = await context.Products.ToListAsync();

            return mapper.Map<List<Product>, List<ProductResource>>(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductResource productResource)
        {
            var product = mapper.Map<ProductResource, Product>(productResource);

            context.Products.Add(product);
            await context.SaveChangesAsync();

            var result = mapper.Map<Product, ProductResource>(product);
            
            return Ok(result);
        }
    }
}