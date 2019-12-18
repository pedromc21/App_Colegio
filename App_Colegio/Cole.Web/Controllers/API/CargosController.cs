namespace Cole.Web.Controllers.API
{
    using Cole.Web.Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class CargosController : Controller
    {
        private readonly ICargoRepository cargoRepository;

        public CargosController(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }
        [HttpGet]
        public IActionResult GetCargos()
        {
            return Ok(this.cargoRepository.GetAll());
        }
    }
}
