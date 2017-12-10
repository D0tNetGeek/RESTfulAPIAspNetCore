using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly ILibraryRepository _repository;

        public AuthorsController(ILibraryRepository repository)
        {
            _repository = repository;
        }

        // GET api/authors
        [HttpGet]
        public IActionResult Authors()
        {
            var authorsFromRepo = _repository.GetAuthors();

            return new JsonResult(authorsFromRepo);
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/authors
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/authors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
