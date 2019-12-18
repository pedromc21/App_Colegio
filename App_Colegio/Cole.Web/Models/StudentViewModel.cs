namespace Cole.Web.Models
{
    using Cole.Web.Data.Entities;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class StudentViewModel : Student
    {
        [Display (Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
