namespace probnyKol1.DTO;

public class PrescriptionDTO
{
    private int IdPrescription { set; get; }
    public DateTime Date { set; get; }
    public DateTime DueDate { set; get; }
    public int IdPatient { set; get; }
    public int IdDoctor { set; get; }
}