using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pag_Web.Pages;
using Pag_Web.models;
using Pag_Web.services;
using System.Collections.Generic;

namespace Pag_Web.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        public ProductosService _productosService;
        public ProductosController(ProductosService productosService)
        {
            _productosService = productosService; 
        }

        [HttpGet]
        /*public IActionResult<List<Productos>> Get()
        {
            _productosService.Get;
        }*/
        public ActionResult<List<Productos>> Get()
        {
            return _productosService.Get();
        }
    }
}
