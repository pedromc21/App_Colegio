namespace Cole.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cargo : IEntity
    {
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public int Persona_Id { get; set; }
        [ScaffoldColumn(false)]
        public int IdCiclo { get; set; }
        [ScaffoldColumn(false)]
        public int LLaveRef { get; set; }

        [Display(Name = "Plantel")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Plantel { get; set; }

        [Display(Name = "Concepto")]
        [MaxLength(250, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Concepto { get; set; }

        [Display(Name = "Total")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; }

        [Display(Name = "Recargo")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Recargo { get; set; }

        [Display(Name = "Abono")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Abono { get; set; }

        [Display(Name = "Saldo")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Saldo { get; set; }

        [Display(Name = "Fecha Vencimiento")]
        public DateTime FechaVencimiento { get; set; }

    }
}
