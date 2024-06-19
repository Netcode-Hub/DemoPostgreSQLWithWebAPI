using DemoPostgreSQLWithWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoPostgreSQLWithWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(AppDbContext dbContext) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();
            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts() => Ok(await dbContext.Products.ToListAsync());

    }
}
