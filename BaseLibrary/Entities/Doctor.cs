using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Doctor : OtherBaseEntity
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string MedicalDiagnoses { get; set; } = string.Empty;
        [Required]
        public string MedicalRecomendation { get; set; } = string.Empty;

    }
}
