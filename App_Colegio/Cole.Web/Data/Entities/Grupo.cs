namespace Cole.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Grupo : IEntity
    {
        public int Id { get; set; }

        public int Persona_Id { get; set; }

        [Display(Name = "Clave")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Clave { get; set; }

        [Display(Name = "Grupo")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string NameGrupo { get; set; }

        [Display(Name = "Tipo Grupo")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string TipoGrupo { get; set; }
    }
}
