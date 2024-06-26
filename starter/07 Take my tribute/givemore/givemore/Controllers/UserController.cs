using Microsoft.AspNetCore.Mvc;
// get user
// get users
// insert user
// delete user
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
        [HttpPost]
        public ActionResult<User> InsertUser([FromBody][Required] User newUser)
        {
            // This is just a placeholder. In a real application, you would insert the user into your database and return the inserted user with the generated ID.
            newUser.FirstName = "John";
            newUser.LastName = "Doe";
            newUser.Email = "john.doe@example.com";
            newUser.Password = "password";

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            // This is just a placeholder. In a real application, you would use the id to delete the user from your database.
            bool userExists = true; // Change this to check if the user exists in your database.

            if (!userExists)
            {
                return NotFound();
            }

            // Delete the user from your database here.

            return NoContent();
        }

    }
}

