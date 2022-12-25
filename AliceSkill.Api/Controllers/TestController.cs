using Microsoft.AspNetCore.Mvc;
using AliceSkill.Api.Services;
namespace AliceSkill.Api.Controllers;

[Route("api/[controller]/[action]")]
public class TestController : ControllerBase
{
    private readonly TestService _service;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="testService"></param>
    public TestController( TestService testService)
    {
        _service = testService;
    }

    [HttpGet]
    public string Test()
    {
        return "test";
        //return _service.Test();
    }
}