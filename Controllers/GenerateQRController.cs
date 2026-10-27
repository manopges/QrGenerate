using Microsoft.AspNetCore.Mvc;
using QrMicroservice.Models;
using QrMicroservice.Services;

namespace QrMicroservice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenerateQRController : ControllerBase
{
    private readonly IQrService _qrService;

    public GenerateQRController(IQrService qrService)
    {
        _qrService = qrService;
    }

    [HttpPost]
    public ActionResult<QrGenerateResponse> Post([FromBody] QrGenerateRequest request)
    {
        try
        {
            var response = _qrService.Generate(request);
            return Ok(response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}
