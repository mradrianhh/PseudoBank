using Microsoft.AspNetCore.Mvc;
using PseudoBank.Common.DataModels;
using PseudoBank.EFCore;

namespace PseudoBank.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;
    private readonly DatabaseContext _context;

    public ProductController(ILogger<ProductController> logger, DatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetProducts")]
    public IActionResult Get()
    {
        return Ok(_context.Produkt);
    }
}
