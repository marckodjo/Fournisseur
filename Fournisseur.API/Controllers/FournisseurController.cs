using Fournisseur.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fournisseur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseurController : ControllerBase
    {
        private readonly IFournisseurRepository _fournisseurRepository;

        public FournisseurController(IFournisseurRepository fournisseurRepository)
        {
            _fournisseurRepository = fournisseurRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetFournisseur()
        {

            return Ok(_fournisseurRepository.GetFournisseurs());
        }

        [HttpPost]
        public async Task<IActionResult> AddFournisseur([FromBody] Models.Fournisseur _fournisseur)
        {

            return Ok(_fournisseurRepository.AddFournisseur(_fournisseur));
        }
    }
}
