using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunctionThree.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    // GET calculator/add/4/2/
    [HttpGet("add/{x}/{y}")]
    public ActionResult<int> Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return Ok(x + y);
    }

    // GET calculator/substract/4/2/
    [HttpGet("subtract/{x}/{y}")]
    public ActionResult<int> Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        return Ok(x - y);
    }

    // GET calculator/multiply/4/2/
    [HttpGet("multiply/{x}/{y}")]
    public ActionResult<int> Multiply(int x, int y)
    {
        _logger.LogInformation($"{x} multiply {y} is {x * y}");
        return Ok(x * y);
    }

    // GET calculator/divide/4/2/
    [HttpGet("divide/{x}/{y}")]
    public ActionResult<int> Divide(int x, int y)
    {
        _logger.LogInformation($"{x} divide {y} is {x / y}");
        return Ok(x / y);
    }
}
