using Microsoft.AspNetCore.Mvc;

namespace FunctionOne.Controllers;

[ApiController]
[Route("[controller]")]
public class Capture : ControllerBase
{
    private readonly ILogger<Capture> _logger;

    public Capture(ILogger<Capture> logger)
    {
        _logger = logger;
    }

    [HttpPost("c/{x}/{y}")]
    public int C(int x, int y, HttpRequest request)    
    {

        _logger.LogInformation($"{request.Body}");

        _logger.LogInformation($"{x} plus {y} is {x + y}");

        //_logger.LogInformation($"Body of request : {z}");

        return x + y;
    }


    // GET calculator/add/4/2/
    [HttpGet("add/{x}/{y}")]
    public int Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return x + y;
    }

    // GET calculator/substract/4/2/
    [HttpGet("subtract/{x}/{y}")]
    public int Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        return x - y;
    }

    // GET calculator/multiply/4/2/
    [HttpGet("multiply/{x}/{y}")]
    public int Multiply(int x, int y)
    {
        _logger.LogInformation($"{x} multiply {y} is {x * y}");
        return x * y;
    }

    // GET calculator/divide/4/2/
    [HttpGet("divide/{x}/{y}")]
    public int Divide(int x, int y)
    {
        _logger.LogInformation($"{x} divide {y} is {x / y}");
        return x / y;
    }
}
