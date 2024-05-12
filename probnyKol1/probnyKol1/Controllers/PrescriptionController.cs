using Microsoft.AspNetCore.Mvc;
using probnyKol1.Interfaces;
namespace probnyKol1.Controllers;

[Route("api/prescriptions")]
[ApiController]
public class PrescriptionController : ControllerBase
{
    private IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPrescriptionsAsync(string doctorName = "default")
    {
        var prescriptionsList = await _prescriptionService.GetPrescriptionsAsync(doctorName);
        return Ok(prescriptionsList);
    }
}

