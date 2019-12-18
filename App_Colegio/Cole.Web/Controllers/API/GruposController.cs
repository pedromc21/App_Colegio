namespace Cole.Web.Controllers.API
{
    using Cole.Web.Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class GruposController : Controller
    {
        private readonly IGrupoRepository grupoRepository;

        public GruposController(IGrupoRepository grupoRepository)
        {
            this.grupoRepository = grupoRepository;
        }
        [HttpGet]
        public IActionResult GetGrupos()
        {
            return Ok(this.grupoRepository.GetAll());
        }
    }
}
