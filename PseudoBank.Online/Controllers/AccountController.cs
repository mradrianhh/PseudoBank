using Microsoft.AspNetCore.Mvc;
using PseudoBank.Common.DataModels;
using PseudoBank.EFCore;

namespace PseudoBank.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    private readonly ILogger<AccountController> _logger;
    private readonly DatabaseContext _context;

    public AccountController(ILogger<AccountController> logger, DatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetAccounts")]
    public IActionResult Get()
    {
        return Ok(_context.Konto);
    }
}
