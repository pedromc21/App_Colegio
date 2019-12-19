namespace Cole.Web.Controllers.API
{
    using Cole.Web.Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class TutorsController : Controller
    {
        private readonly ITutorRepository tutorRepository;

        public TutorsController(ITutorRepository tutorRepository)
        {
            this.tutorRepository = tutorRepository;
        }
        [HttpGet]
        public IActionResult GetTutors()
        {
            return Ok(this.tutorRepository.GetAllWithUsers());
        }
    }
}
