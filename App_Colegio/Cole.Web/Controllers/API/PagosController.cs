namespace Cole.Web.Controllers.API
{
    using Cole.Web.Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class PagosController : Controller
    {
        private readonly IPagoRepository pagoRepository;

        public PagosController(IPagoRepository pagoRepository)
        {
            this.pagoRepository = pagoRepository;
        }
        [HttpGet]
        public IActionResult GetPagos()
        {
            return Ok(this.pagoRepository.GetAll());
        }
    }
}
