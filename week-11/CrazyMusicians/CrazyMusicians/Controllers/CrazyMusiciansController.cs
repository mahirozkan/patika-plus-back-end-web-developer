using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyMusiciansController : ControllerBase
    {
        private static List<CrazyMusician> _crazyMusicians = new List<CrazyMusician>()
        {
            new CrazyMusician { Id = 1, Name = "Ahmet Çalgı", Job = "Ünlü Çalgı Çalar", Feature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new CrazyMusician { Id = 2, Name = "Zeynep Melodi", Job = "Popüler Melodi Yazarı", Feature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new CrazyMusician { Id = 3, Name = "Cemil Akor", Job = "Çılgın Akorist", Feature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new CrazyMusician { Id = 4, Name = "Fatma Nota", Job = "Sürpriz Nota Üreticisi", Feature = "Nota üretirken sürekli sürprizler hazırlar" },
            new CrazyMusician { Id = 5, Name = "Hasan Ritim", Job = "Ritim Canavarı", Feature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new CrazyMusician { Id = 6, Name = "Elif Armoni", Job = "Armoni Ustası", Feature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new CrazyMusician { Id = 7, Name = "Ali Perde", Job = "Perde Uygulayıcı", Feature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new CrazyMusician { Id = 8, Name = "Ayşe Rezonans", Job = "Rezonans Uzmanı", Feature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new CrazyMusician { Id = 9, Name = "Murat Ton", Job = "Tonlama Meraklısı", Feature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new CrazyMusician { Id = 10, Name = "Selin Akor", Job = "Akor Sihirbazı", Feature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
        };

        [HttpGet]
        public IEnumerable<CrazyMusician> GetAll()
        {
            return _crazyMusicians;
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<CrazyMusician> GetMusician(int id)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
            {
                return NotFound($"Musician with Id={id} not found.");
            }

            return Ok(musician);
        }

        [HttpGet("search")]
        public ActionResult<IEnumerable<CrazyMusician>> GetByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name can't be null.");
            }
            var musician = _crazyMusicians
                .Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!musician.Any())
            {
                return NotFound($"Musician with \"{name}\" not found");
            }

            return Ok(musician);
        }

        [HttpPost]
        public ActionResult<CrazyMusician> Create([FromBody] CrazyMusician crazyMusician)
        {
            var id = _crazyMusicians.Max(x => x.Id) + 1;
            crazyMusician.Id = id;

            _crazyMusicians.Add(crazyMusician);

            return CreatedAtAction(nameof(Create), new { id = crazyMusician.Id }, crazyMusician);
        }

        [HttpPatch("feature/patch/{id:int:min(1)}")]
        public IActionResult PatchFeature(int id, [FromBody] string newFeature)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
            {
                return NotFound($"Musician with Id={id} not found.");
            }

            if (string.IsNullOrWhiteSpace(newFeature))
            {
                return BadRequest("Feature can't be null or empty.");
            }

            musician.Feature = newFeature;
            return NoContent();
        }

        [HttpPut("update/{id:int:min(1)}/{newName}")]
        public IActionResult UpdateName(int id, string newName)
        {
            var musician = _crazyMusicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
            {
                return NotFound($"Musician with Id={id} not found.");
            }

            musician.Name = newName;

            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult Delete(int id)
        {
            var musicianToDelete = _crazyMusicians.FirstOrDefault(x => x.Id == id);

            if (musicianToDelete ==null) 
            { 
                return NotFound($"Musician with Id={id} not found.");
            }

            _crazyMusicians.Remove(musicianToDelete);
            return Ok($"Musician with Id={id} has been deleted.");
        }
    }
}
