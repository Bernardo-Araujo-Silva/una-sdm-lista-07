using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] Dicas = new[]
        {
            "Use transporte público sempre que possível.",
            "Evite desperdício de água.",
            "Reduza o uso de plástico.",
            "Prefira energia renovável.",
            "Recicle sempre que possível."
        };

        [HttpGet]
        public string Get()
        {
            var random = new Random();
            int index = random.Next(Dicas.Length);

            return Dicas[index];
        }
    }
}