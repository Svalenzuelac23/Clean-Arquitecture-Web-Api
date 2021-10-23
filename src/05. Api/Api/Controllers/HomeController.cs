using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.CQRS.Query.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWebHostEnvironment host;

        public HomeController(
            IWebHostEnvironment host
            )
        {
            this.host = host;
        }

        [HttpGet("ping")]
        public ActionResult Ping(PersonDTO personDTO)
        {
            return Ok(personDTO);
        }

        [HttpGet("enviroment")]
        public IActionResult Enviroment()
        {
            return Ok(host.EnvironmentName);
        }
    }
}