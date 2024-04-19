using Microsoft.AspNetCore.Mvc;
// get user
// get users
namespace givemore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            // This is just a placeholder. In a real application, you would use the id to get the user from your database.
            User user = new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password" };

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            // This is just a placeholder. In a real application, you would get the users from your database.
            List<User> users = new List<User>
            {
                new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password" },
                new User { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", Password = "password" }
             };

            return users;
        }

    }
}

