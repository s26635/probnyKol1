using Microsoft.AspNetCore.Mvc;
using probnyKol1.DTO;
using probnyKol1.Interfaces;
using probnyKol1.Models;

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

    [HttpGet("{doctorName}")]
    public async Task<IActionResult> GetPrescriptionsAsync(string doctorName = "default")
    {
        try
        {
            var prescriptionsList = await _prescriptionService.GetPrescriptionsAsync(doctorName);
            return Ok(prescriptionsList);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error");
            
            
        }
    }

    // [HttpPost]
    // public async Task<IActionResult> AddPrescription([FromBody] PrescriptionDTO prescriptionDTO)
    // {
    //     try
    //     {
    //         Prescription newPrescription = await _prescriptionService.AddPrescriptionAsync(prescriptionDTO);
    //         return CreatedAtAction(nameof(GetPrescription), new { id = newPrescription.IdPrescription }, newPrescription);
    //     }
    //     catch (ArgumentException ex)
    //     {
    //         return BadRequest(ex.Message);
    //     }
    //     catch (Exception ex)
    //     {
    //         return StatusCode(500, "Internal server error");
    //     }
    // }

}

