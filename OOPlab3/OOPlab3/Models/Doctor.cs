using System.ComponentModel.DataAnnotations.Schema;

namespace OOPlab3.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DateId { get; set; }
        [ForeignKey("DateId")]
        public Date? Date { get; set; }
    }
}
