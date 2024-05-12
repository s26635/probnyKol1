namespace probnyKol1.Models;

public class Prescription
{
    private int IdPrescription { set; get; }
    private DateTime Date { set; get; }
    private DateTime DueDate { set; get; }
    private int IdPatient { set; get; }
    private int IdDoctor { set; get; }
}