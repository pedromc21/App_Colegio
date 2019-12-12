namespace Cole.Web.Controllers.API
{
    using Cole.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(this.studentRepository.GetAll());
        }
    }
}
