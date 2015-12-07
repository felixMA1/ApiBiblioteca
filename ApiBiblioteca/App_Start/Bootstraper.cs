using System.Data.Entity;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioBiblioteca.Model;
using RepositorioBiblioteca.ViewModel;

namespace ApiBiblioteca
{
    public class Bootstraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, BibliotecaEntities>();
            container.RegisterType<IRepositorio<Libro,LibroViewModel>,RepositorioEntity<Libro,LibroViewModel>>();
            container.RegisterType<IRepositorio<Usuario, UsuarioViewModel>, RepositorioEntity<Usuario, UsuarioViewModel>>();
        }
    }
}