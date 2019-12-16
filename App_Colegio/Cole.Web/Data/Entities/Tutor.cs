namespace Cole.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Tutor : IEntity
    {
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public int Persona_Id { get; set; }

        [Display(Name = "Clave Familia")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Clave_Familia { get; set; }

        [Display(Name = "Apellido Paterno")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Apellido_Materno { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Nombres { get; set; }

        [Display(Name = "Parentesco")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Parentesco { get; set; }

        [Display(Name = "Tutor Principal")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public bool Tutor_Principal { get; set; }

        //Relacion con la tabla User
        public User User { get; set; }
    }
}
