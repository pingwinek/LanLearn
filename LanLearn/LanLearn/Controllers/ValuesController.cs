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

            return Ok(words);
        }

        //GET api/values
       [HttpGet]
        public ActionResult GetResult(int translateId)
        {
            var result = _translateService.GetTranslate(translateId);

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string[] value)
        {
            _translateService.SendTranslate(value);
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
