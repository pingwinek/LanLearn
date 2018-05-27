using System.Linq;
using Dto;
using LanLearn.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanLearn.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ITranslateService _translateService;

        public ValuesController(ITranslateService translateService)
        {
            _translateService = translateService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()

        {
            var words = _translateService.GetListWords(8).Select(a => new Word
            {
                WordId = a.Id,
                Name = a.EnglishWord,
                Rank = a.Rank
            }).ToList();

            //var model = new WordsList
            //{
            //    Words = words
            //};

            return Ok(words);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
