namespace probnyKol1.Interfaces;

public interface IPrescriptionService
{
    Task<List<List<string>>> GetPrescriptionsAsync(string doctorName);
}