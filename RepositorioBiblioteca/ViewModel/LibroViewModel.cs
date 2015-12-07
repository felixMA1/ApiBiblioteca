using BaseRepositorio.ViewModel;
using RepositorioBiblioteca.Model;

namespace RepositorioBiblioteca.ViewModel
{
    public class LibroViewModel:IViewModel<Libro>
    {

        public int cod_libro { get; set; }
        public string nombre { get; set; }
        public string editorial { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }


        public Libro ToBaseDatos()
        {
            return new Libro()
            {
                cod_libro = cod_libro,
                nombre = nombre,
                editorial = editorial,
                autor = autor,
                genero = genero
            };
        }

        public void FromBaseDatos(Libro modelo)
        {
            cod_libro = modelo.cod_libro;
            nombre = modelo.nombre;
            editorial = modelo.editorial;
            autor = modelo.autor;
            genero = modelo.genero;
        }

        public void UpdateBaseDatos(Libro modelo)
        {
            modelo.cod_libro = cod_libro;
            modelo.nombre = nombre;
            modelo.editorial = editorial;
            modelo.autor = autor;
            modelo.genero = genero;
        }

        public object[] GetKeys()
        {
            return new []{(object)cod_libro};
        }
    }
}