using probnyKol1.DTO;
using probnyKol1.Interfaces;
using probnyKol1.Models;
using probnyKol1.Repositories;

namespace probnyKol1.Services;

public class PrescriptionService : IPrescriptionService
{
    private IPrescriptionRepository _prescriptionRepository;

    public PrescriptionService(IPrescriptionRepository prescriptionRepository)
    {
        _prescriptionRepository = prescriptionRepository;
    }

    public Task<List<List<string>>> GetPrescriptionsAsync(string doctorName)
    {
       return _prescriptionRepository.GetPrescriptionsAsync(doctorName);
    }

    public Task<Prescription> AddPrescriptionAsync(PrescriptionDTO prescriptionDTO)
    {
        return _prescriptionRepository.AddPrescriptionAsync(prescriptionDTO);
    }
}