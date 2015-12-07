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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuariosController : ApiController
    {

        [Dependency]
        public IRepositorio<Usuario, UsuarioViewModel> Repositorio { get; set; }

        public ICollection<UsuarioViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof(UsuarioViewModel))]
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }


        [ResponseType(typeof(UsuarioViewModel))]
        public IHttpActionResult ActualizarUsuario(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPut]
        [ResponseType(typeof(UsuarioViewModel))]
        public IHttpActionResult ActualizarUsuario(UsuarioViewModel model)
        {
            var data = Repositorio.Actualizar(model);
            return Created("ApiBiblioteca", data);
        }

        [HttpPost]
        [ResponseType(typeof(UsuarioViewModel))]
        public IHttpActionResult NuevoUsuario(UsuarioViewModel model)
        {
            var data = Repositorio.Add(model);
            if (data == null)
                return BadRequest("Error al crear objeto");

            return Created("ApiBiblioteca", data);
        }

        [HttpDelete]
        [ResponseType(typeof(UsuarioViewModel))]
        public IHttpActionResult BorrarUsuario(int id)
        {
            var data = Repositorio.Borrar(id);
            return Ok(data);
        }
    }
}
