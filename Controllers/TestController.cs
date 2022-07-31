using MallAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly SouqContext _context;

        public TestController(SouqContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            return await _context.Products.ToListAsync();
        }

        //[HttpGet]
        //public IEnumerable<Product> GetProducts()
        //{
        //    using (var context = new SouqContext())
        //    {
        //        if (context.Products == null)
        //        {
        //            return (IEnumerable<Product>)NotFound();
        //        }
        //        return context.Products.ToList();
        //    }
        //}
    }
}
