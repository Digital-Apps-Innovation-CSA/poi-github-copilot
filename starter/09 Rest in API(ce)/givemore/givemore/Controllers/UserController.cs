using Microsoft.AspNetCore.Mvc;
// get user
// get users
// insert user
// delete user
//local list of users
namespace givemore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        private static List<User> users = new List<User>
        {
            new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password" },
            new User { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", Password = "password" }
        };

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            // This is just a placeholder. In a real application, you would use the id to get the user from your database.
             User user = users.FirstOrDefault(u => u.Id == id);

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
            return users;
        }
        [HttpPost]
        public ActionResult<User> InsertUser([FromBody][Required] User newUser)
        {
            // This is just a placeholder. In a real application, you would insert the user into your database and return the inserted user with the generated ID.
            users.Add(newUser);

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
        }
                [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            // Use the id to get the user from the local list.
            User user = users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }
            users.Remove(user);

            // Remove the user from the local list.

            return NoContent();
        }

    }
}

