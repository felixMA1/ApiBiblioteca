using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioBiblioteca.Model;
using RepositorioBiblioteca.ViewModel;

namespace ApiBiblioteca.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class LibrosController : ApiController
    {

        [Dependency]
        public IRepositorio<Libro,LibroViewModel> Repositorio { get; set; }

        public ICollection<LibroViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof (LibroViewModel))]
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)            
                return NotFound();

            return Ok(data);
        }


        [ResponseType(typeof(LibroViewModel))]
        public IHttpActionResult ActualizarLibro(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPut]
        [ResponseType(typeof(LibroViewModel))]
        public IHttpActionResult ActualizarLibro(LibroViewModel model)
        {
            var data = Repositorio.Actualizar(model);
            return Created("ApiBiblioteca", data);
        }

        [HttpPost]
        [ResponseType(typeof(LibroViewModel))]
        public IHttpActionResult NuevoLibro(LibroViewModel model)
        {
            var data = Repositorio.Add(model);
            if (data == null)
                return BadRequest("Error al crear objeto");

            return Created("ApiBiblioteca", data);
        }

        [HttpDelete]
        [ResponseType(typeof (LibroViewModel))]
        public IHttpActionResult BorrarLibro(int id)
        {

            var data = Repositorio.Borrar(id);
            return Ok(data);
        }





    }
}
