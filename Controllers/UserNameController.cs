using Microsoft.AspNetCore.Mvc;

namespace CadeRBackendSayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserNameController : ControllerBase
    {

        [HttpGet] // Use HttpPost for adding info to the backend
        [Route("AddName/{userName}")] // To pass data through our routes we add /{parameter}
        public string AddToUserNames(string userName)
        {
              
            return $"Hello {userName}, Nice to see you again.";
        }

    }
}