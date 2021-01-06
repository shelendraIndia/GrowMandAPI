using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowMandiApi.Services.BuyProducts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrowMandiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBuyProductService _buyProductService;

        public ProductController(IBuyProductService buyProductService) {
            _buyProductService = buyProductService;
        }

        [HttpGet]
        public string Get()
        {
            return _buyProductService.test();
        }

    }
}