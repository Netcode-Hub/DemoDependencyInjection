using DemoDependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoDependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //public class ShippingController
    //  (Func<string, IShippingService> resolveShippingService) : ControllerBase
    //{

    //    [HttpGet("express")]
    //    public IActionResult Express()
    //    {
    //        var shippingService = resolveShippingService("Express");
    //        return Ok(shippingService.CalculateShippingCost(45.3m));
    //    }

    //    [HttpGet("standard")]
    //    public IActionResult Standard()
    //    {
    //        var shippingService = resolveShippingService("Standard");
    //        return Ok(shippingService.CalculateShippingCost(45.3m));
    //    }

    //    [HttpGet("international")]
    //    public IActionResult International()
    //    {
    //        var shippingService = resolveShippingService("International");
    //        return Ok(shippingService.CalculateShippingCost(45.3m));
    //    }
    //}

    public class ShippingController
      (
        [FromKeyedServices("Express")] IShippingService express,
        [FromKeyedServices("Standard")] IShippingService standard,
        [FromKeyedServices("International")] IShippingService international
        ) : ControllerBase
    {

        [HttpGet("express")]
        public IActionResult Express()
        {
            return Ok(express.CalculateShippingCost(45.3m));
        }

        [HttpGet("standard")]
        public IActionResult Standard()
        {
            return Ok(standard.CalculateShippingCost(45.3m));
        }

        [HttpGet("international")]
        public IActionResult International()
        {
            return Ok(international.CalculateShippingCost(45.3m));
        }
    }
}
