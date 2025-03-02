using Microsoft.AspNetCore.Mvc;
using CrazyMusicians_Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrazyMusicians_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusiciansController : ControllerBase
    {
        private static readonly List<Musician> musicians = new List<Musician>
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunnyFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunnyFeature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Musician { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunnyFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Musician { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunnyFeature = "Nota üretirken sürekli sürprizler hazırlar" },
            new Musician { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunnyFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Musician { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunnyFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new Musician { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcısı", FunnyFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Musician { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunnyFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Musician { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunnyFeature = "Tonlamalardaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Musician { Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunnyFeature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetAllMusicians()
        {
            return Ok(musicians);
        }

        [HttpGet("{id}")]
        public ActionResult<Musician> GetMusicianById(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
            {
                return NotFound(new { message = "Musician not found" });
            }
            return Ok(musician);
        }

        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string name)
        {
            var results = musicians.Where(m => m.Name.ToLower().Contains(name.ToLower())).ToList();
            return Ok(results);
        }

        [HttpPost]
        public ActionResult<Musician> CreateMusician([FromBody] Musician musician)
        {
            musician.Id = musicians.Max(m => m.Id) + 1;
            musicians.Add(musician);
            return CreatedAtAction(nameof(GetMusicianById), new { id = musician.Id }, musician);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMusician(int id, [FromBody] Musician updatedMusician)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
            {
                return NotFound(new { message = "Musician not found" });
            }

            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunnyFeature = updatedMusician.FunnyFeature;
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateMusicianFeature(int id, [FromBody] string newFeature)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
            {
                return NotFound(new { message = "Musician not found" });
            }

            musician.FunnyFeature = newFeature;
            return Ok(musician);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMusician(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
            {
                return NotFound(new { message = "Musician not found" });
            }

            musicians.Remove(musician);
            return NoContent();
        }
    }
}
