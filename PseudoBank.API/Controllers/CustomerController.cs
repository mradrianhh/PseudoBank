using Microsoft.AspNetCore.Mvc;
using PseudoBank.Common.DataModels;
using PseudoBank.EFCore;

namespace PseudoBank.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{

    private readonly ILogger<CustomerController> _logger;
    private readonly DatabaseContext _context;

    public CustomerController(ILogger<CustomerController> logger, DatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetCustomers")]
    public IActionResult Get()
    {
        return Ok(_context.Kunde);
    }
}
