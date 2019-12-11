namespace Cole.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        public int Id { get; set; }

        public int Persona_Id { get; set; }

        [Display(Name = "Apellido Paterno")]
        [MaxLength(50)]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [MaxLength(50)]
        public string Apellido_Materno { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50)]
        public string Nombres { get; set; }

        [Display(Name = "Matricula")]
        [MaxLength(20)]
        public string Matricula { get; set; }

        [Display(Name = "Clave_Familia")]
        [MaxLength(20)]
        public string Clave_Familia { get; set; }

        [Display(Name = "Nivel Educativo")]
        [MaxLength(20)]
        public string Nivel { get; set; }
    }
}
