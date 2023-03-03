using Microsoft.AspNetCore.Mvc;
using PseudoBank.Common.DataModels;
using PseudoBank.EFCore;

namespace PseudoBank.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductServiceController : ControllerBase
{

    private readonly ILogger<ProductServiceController> _logger;
    private readonly DatabaseContext _context;

    public ProductServiceController(ILogger<ProductServiceController> logger, DatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetProductServices")]
    public IActionResult Get()
    {
        return Ok(_context.ProduktTjeneste);
    }
}
