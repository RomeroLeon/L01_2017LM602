
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2017LM602;
using Microsoft.EntityFrameworkCore;

namespace L01_2017LM602.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Restaurante : ControllerBase
    {
        private readonly Restaurante _RestauranteContexto;

        public Restaurante(Restaurante restaurante_Contexto)
        {
            _RestauranteContexto = restaurante_Contexto;
        }
    }
}
