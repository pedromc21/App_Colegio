
namespace Cole.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Period : IEntity
    {
        public int Id { get; set; }
        public int Periodo_Id { get; set; }

        [Display(Name = "Ciclo Escolar")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Ciclo_Escolar { get; set; }
    }
}
