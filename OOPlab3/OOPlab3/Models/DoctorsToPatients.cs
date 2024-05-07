using System.ComponentModel.DataAnnotations.Schema;


namespace OOPlab3.Models
{
    public class DoctorsToPatients
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
    }
}
