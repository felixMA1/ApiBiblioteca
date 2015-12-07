using BaseRepositorio.ViewModel;
using RepositorioBiblioteca.Model;

namespace RepositorioBiblioteca.ViewModel
{
    public class UsuarioViewModel:IViewModel<Usuario>
    {
        public int cod_usuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string domicilio { get; set; }

        public Usuario ToBaseDatos()
        {
            return new Usuario()
            {
                cod_usuario = cod_usuario,
                nombre = nombre,
                apellidos = apellidos,
                dni = domicilio,
                domicilio = domicilio
            };
        }

        public void FromBaseDatos(Usuario modelo)
        {
            cod_usuario = modelo.cod_usuario;
            nombre = modelo.nombre;
            apellidos = modelo.apellidos;
            dni = modelo.dni;
            domicilio = modelo.domicilio;
        }

        public void UpdateBaseDatos(Usuario modelo)
        {
            modelo.cod_usuario = cod_usuario;
            modelo.nombre = nombre;
            modelo.apellidos = apellidos;
            modelo.dni = dni;
            modelo.domicilio = domicilio;
        }

        public object[] GetKeys()
        {
            return new[] { (object)cod_usuario };
        }
    }
}