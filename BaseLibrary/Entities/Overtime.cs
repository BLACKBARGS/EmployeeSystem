using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Overtime : OtherBaseEntity
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int NumberOfDays => (EndDate - StartDate).Days;
        public OvertimeType? OvertimeType { get; set; }
        [Required]
        public int OvertimeTypeId { get; set; }
    }
}

// https://youtu.be/yRnI5tnbcGk?list=PL285LgYq_FoKoxiqmUEgVX3_wFf1ioi3J&t=2181