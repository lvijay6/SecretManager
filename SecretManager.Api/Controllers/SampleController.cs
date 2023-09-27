using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SecretManager.Api.Configuration;

namespace SecretManager.Api.Controllers;

[ApiController]
public class SampleController : ControllerBase
{
    private readonly IOptionsMonitor<DatabaseSettings> _databaseSettings;

    public SampleController(IOptionsMonitor<DatabaseSettings> databaseSettings)
    {
        _databaseSettings = databaseSettings;
    }

    [HttpGet("settings")]
    public IActionResult GetSettings()
    {
        var settings = _databaseSettings.CurrentValue;
        return Ok(settings);
    }
}
