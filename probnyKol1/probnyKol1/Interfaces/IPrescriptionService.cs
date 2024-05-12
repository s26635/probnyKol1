using probnyKol1.DTO;
using probnyKol1.Models;

namespace probnyKol1.Interfaces;

public interface IPrescriptionService
{
    Task<List<List<string>>> GetPrescriptionsAsync(string doctorName);

    Task<Prescription> AddPrescriptionAsync(PrescriptionDTO prescriptionDTO);
}