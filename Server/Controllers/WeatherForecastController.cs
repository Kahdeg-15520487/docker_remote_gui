using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Docker.DotNet;
using Docker.DotNet.Models;

using docker_remote_gui_2.Shared;

namespace docker_remote_gui_2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 8).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("docker")]
        public ActionResult GetDocker(){
            DockerClient client = new DockerClientConfiguration(new Uri("http://192.168.50.202:2375")).CreateClient();
            IList<Docker.DotNet.Models.ContainerListResponse> containers = client.Containers.ListContainersAsync(
                                                                        new ContainersListParameters()
                                                                        {
                                                                            Limit = 10,
                                                                        }).Result;

            return Ok(containers);
        }
    }
}
