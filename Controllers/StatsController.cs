using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkcelitaTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkcelitaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : Controller
    {

        private readonly DatabaseContext _context;

        public StatsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("city")]
        public async Task<ActionResult<IEnumerable<SalesPerCityDTO>>> GetSalesPerCity()
        {
            throw new NotImplementedException();
        }

        [HttpGet("order-per-users")]
        public async Task<ActionResult<IEnumerable<OrdersPerUserDTO>>> GetOrdersPerUsers()
        {
            throw new NotImplementedException();
        }

        [HttpGet("order-per-users")]
        public async Task<ActionResult<IEnumerable<ProductsSoldDTO>>> GetProductsSold()
        {
            throw new NotImplementedException();
        }
    }
}