namespace Cole.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        //Cambios a a tablas
        //dotnet ef migrations add ModifyStudents
        //dotnet ef database update
        public int Id { get; set; }

        public int Persona_Id { get; set; }

        [Display(Name = "Apellido Paterno")]
        [MaxLength(50, ErrorMessage="El {0} solo puede contener {1} de longitud")]
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

        [Display(Name = "Matricula")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Matricula { get; set; }

        [Display(Name = "Clave_Familia")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Clave_Familia { get; set; }

        [Display(Name = "Nivel Educativo")]
        [MaxLength(20, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Nivel { get; set; }

        [Display(Name = "Grado")]
        [MaxLength(50, ErrorMessage = "El {0} solo puede contener {1} de longitud")]
        [Required]
        public string Grado { get; set; }
    }
}
