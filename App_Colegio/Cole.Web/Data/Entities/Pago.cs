namespace Cole.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pago : IEntity
    {
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public int LLaveRef_Enc { get; set; }

        [Display(Name = "Folio")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Folio { get; set; }

        [Display(Name = "Factura-Serie")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Serie_Factura { get; set; }

        [Display(Name = "Factura")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Factura { get; set; }

        [Display(Name = "Importe")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Importe { get; set; }

        [Display(Name = "Descuento")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Descuento { get; set; }

        [Display(Name = "Abono")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Abono { get; set; }

        [Display(Name = "Recargo")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Recargo { get; set; }

        [Display(Name = "TotalAbono")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "decimal(12,2)")]
        public decimal TotalAbono { get; set; }

        [Display(Name = "Fecha Abono")]
        public DateTime FechaAbono { get; set; }

        [Display(Name = "Tipo Pago")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string TipoPago { get; set; }

        [Display(Name = "Banco")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Banco { get; set; }

        [Display(Name = "Referencia")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Referencia { get; set; }

        [Display(Name = "Estatus")]
        [Required]
        public bool Estatus { get; set; }
    }
}
