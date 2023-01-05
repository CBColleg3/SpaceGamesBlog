using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpaceBlogBackend.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceBlogBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamerBlogController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<GamerBlogController> _logger;

        public GamerBlogController(ILogger<GamerBlogController> logger)
        {
            _logger = logger;
        }

        [EnableCors]
        [HttpGet]
        public IEnumerable<GamerBlog> Get()
        {
            /*
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new GamerBlog
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            */
            IEnumerable<GamerBlog> gamerSwag = new GamerBlog[] { };
            return gamerSwag;
        }
    }
}
