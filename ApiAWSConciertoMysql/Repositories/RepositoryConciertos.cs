using ApiAWSConciertoMysql.Data;
using ApiAWSConciertoMysql.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ApiAWSConciertoMysql.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }

        // EVENTOS
        public async Task<List<Eventos>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Eventos>> GetEventosCategoriaAsync(int id)
        {   
            
            return await this.context.Eventos.Where(x => x.IdCategoria== id).ToListAsync();
        }

        public async Task<Eventos> FindEventosAsync(int id)
        {
            return await
                this.context.Eventos
                .FirstOrDefaultAsync(x => x.IdEvento == id);
        }

        private int GetMaxIdEvento()
        {
            return this.context.Eventos.Max(z => z.IdEvento) + 1;
        }

        public async Task CreateEvento(string nombre,string artista, int idcategoria , string imagen)
        {
            Eventos evento = new Eventos();
            evento.IdEvento = this.GetMaxIdEvento();
            evento.Nombre = nombre;
            evento.Artista = artista;
            evento.IdCategoria = idcategoria;
            evento.Imagen = imagen;
            this.context.Eventos.Add(evento);
            await this.context.SaveChangesAsync();
        }

        //CATEGORIAEVENTO

        public async Task<List<CategoriaEvento>> GetCategoriaAsync()
        {
            return await this.context.CategoriaEventos.ToListAsync();
        }

        public async Task<List<CategoriaEvento>> GetCategoriaEventoAsync(int id)
        {

            return await this.context.CategoriaEventos.Where(x => x.IdCategoria == id).ToListAsync();
        }
    }
}
