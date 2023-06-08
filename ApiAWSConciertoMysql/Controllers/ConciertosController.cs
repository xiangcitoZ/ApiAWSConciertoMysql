using ApiAWSConciertoMysql.Models;
using ApiAWSConciertoMysql.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAWSConciertoMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertosController : ControllerBase
    {
        private RepositoryConciertos repo;

        public ConciertosController(RepositoryConciertos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Eventos>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Eventos>> FindEvento(int id)
        //{
        //    return await this.repo.FindEventosAsync(id);
        //}

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<Eventos>>> EventoCategoria(int id)
        {
            
            return await this.repo.GetEventosCategoriaAsync(id);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> CreateEventos(Eventos evento)
        {
            await this.repo.CreateEvento(evento.Nombre, evento.Artista,
                evento.IdCategoria , evento.Imagen);
            return Ok();
        }

        //CATEGORIASEVENTOS
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CategoriaEvento>>> GetCategorias()
        {
            return await this.repo.GetCategoriaAsync();
        }


        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<CategoriaEvento>>> CategoriaEventos(int id)
        {

            return await this.repo.GetCategoriaEventoAsync(id);
        }

    }
}
