using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YatVueApp.Model;
using YatVueApp.Contracts;
using YatVueApp.Repository;

namespace YatVueApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _repository;
        //private readonly IProductRepository _repository;
        
        public ProductController(IRepositoryWrapper repository, ILogger<ProductController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;            
            _mapper = mapper;
        }

        // public ProductController(IProductRepository repository, ILogger<ProductController> logger, IMapper mapper)
        // {
        //     _repository = repository;
        //     _logger = logger;            
        //     _mapper = mapper;
        // }
        
        
        // GET: api/product
        // Retrieves all 'Products' currently in the data store
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var query = _repository.Product.GetAllProducts();
                var results = _mapper.Map<IEnumerable<ProductDto>>(query);
                return Ok(results);
            }
            catch (Exception exception)
            {
                return StatusCode(500, "Internal server error, Message: " + exception.Message);
            }
        }

        // // GET: api/product
        // [HttpGet]
        // public IEnumerable<Product> GetAllProducts()
        // {
        //     return _repository.Product.GetAllProducts();
        // }
    }
}
