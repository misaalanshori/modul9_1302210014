using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302210014.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("Muhammad Isa Al Anshori", "1302210014", new List<string>{"KPL", "PBO", "Basis Data"}, 2021),
            new Mahasiswa("Adam Rafif Faqih", "1302210008", new List<string>{"KPL", "TPLM", "Proyek Tingkat 2"}, 2021),
            new Mahasiswa("Habli Zulvana Ath-Thaariq", "1302210024", new List<string>{"KPL", "Pengalaman Pengguna", "Basis Data"}, 2021),
            new Mahasiswa("Maximus Bayu Proudiasto", "1302210101", new List<string>{"KPL", "PBO", "Proyek Tingkat 2"}, 2021),
            new Mahasiswa("Ilham Nasrullah", "1302210041", new List<string>{"KPL", "PBO", "Pengalaman Pengguna"}, 2021)
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody]Mahasiswa value)
        {
            listMhs.Add(value);
        }


        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMhs.RemoveAt(id);
        }
    }
}
