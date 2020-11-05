using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yat.NetCore31.Spa.Contracts;
using Yat.NetCore31.Spa.Models;

namespace Yat.NetCore31.Spa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _repository;
        
        public ProductController(IRepositoryWrapper repository, ILogger<ProductController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;            
            _mapper = mapper;
        }

        // GET: api/product
        // Retrieves all 'Product' entities currently in the data store
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var query = _repository.Product.GetAllProducts();
				// var results = _mapper.Map<IEnumerable<ProductDto>>(query);
                var results = _mapper.Map<IEnumerable<Product>>(query);
                return Ok(results);
            }
            catch (Exception exception)
            {
                return StatusCode(500, "Internal server error, Message: " + exception.Message);
            }
        }

        // TODO: implement endpoint that accepts a product name and returns the matching product with the highest price

        // TODO: implement endpoint that accepts a product name and returns a list of products grouped by name and sorted by highest price

    }
}
