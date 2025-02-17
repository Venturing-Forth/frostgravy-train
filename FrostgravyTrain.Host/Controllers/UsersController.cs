using Microsoft.AspNetCore.Mvc;

namespace FrostgravyTrain.Host.Controllers;

[ApiController]
[Route("[controller]")]

public class UsersController : ControllerBase
{
    [HttpGet]
    [Route("users/{userId}/warbands")]

    public ServerResult GetUserWarbands(int userId)
    {
        return new ServerResult { };
    }
}