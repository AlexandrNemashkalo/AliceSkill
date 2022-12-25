
namespace AliceSkill.Api.Services;

public class TestService
{
    private readonly ILogger _logger;
    public TestService(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<TestService>();
    }

    public string Test()
    {
        _logger.LogInformation("test");
        return "test";
    }
}