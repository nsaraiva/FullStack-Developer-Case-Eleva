using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IBaseService<Escola> _baseService;

        public EscolaController(IBaseService<Escola> baseService)
        {
            _baseService = baseService;
        }

        // GET: api/<EscolaController>
        [HttpGet]
        public IEnumerable<Escola> Get()
        {
            return _baseService.Get();
        }
    }
}
