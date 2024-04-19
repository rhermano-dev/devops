using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        public class PersonDetails
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
        }

        [HttpGet(Name = "GetPersonDetails")]
        public IActionResult GetPersonDetails()
        {
            PersonDetails details = new PersonDetails
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Reynaldo",
                Age = "25"
            };

            return Ok(details);
        }
    }
}
