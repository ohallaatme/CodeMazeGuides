using Microsoft.AspNetCore.Mvc;

namespace ReadRequestBody.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{


    public UsersController()
    {

    }

    [HttpGet]
    public IActionResult GetUsers()
    {

    }

    [HttpGet("{id:guid}", Name = "UserById")]
    public IActionResult GetUser(Guid id)
    {

    }

}

