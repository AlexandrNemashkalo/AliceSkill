using Microsoft.AspNetCore.Mvc;
using Yandex.Alice.Sdk.Models;

namespace AliceSkill.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AliceController : ControllerBase
{
    [HttpPost]
    [Route("/alice")]
    public IActionResult Get(AliceRequest aliceRequest)
    {
        return Ok(new AliceResponse(aliceRequest, "Hello"));
    }
}
