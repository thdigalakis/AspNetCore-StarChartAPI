using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        CelestialObject celestialObject = new CelestialObject();

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet ("{id:int}"), ActionName("GetById")]
        public IActionResult GetById(int Id)
        {
            if (Id != celestialObject.Id)
            {
                return NotFound();
            }

            
            return 
        }

        [HttpGet ("{name}")]
        public IActionResult GetByName(string name)
        {
            if (name != celestialObject.Name)
            {
                return NotFound();
            }
        }

        public IActionResult GetAll()
        {
            return ();
        }
    }
}
