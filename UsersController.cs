using Microsoft.AspNetCore.Mvc;
using CDNCompleteDeveloperNetwork.Models;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly JsonUserRepository _repository;

    public UsersController()
    {
        _repository = new JsonUserRepository();
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        return Ok(_repository.GetUsers());
    }

    [HttpGet("{id}")]
    public ActionResult<User> GetUser(int id)
    {
        var user = _repository.GetUser(id);
        if (user == null)
            return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public IActionResult PostUser(User user)
    {
        _repository.AddUser(user);
        return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public IActionResult PutUser(int id, User user)
    {
        if (!_repository.UpdateUser(id, user))
            return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        if (!_repository.DeleteUser(id))
            return NotFound();
        return NoContent();
    }
}
