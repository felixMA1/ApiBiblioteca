//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositorioBiblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestamo
    {
        public int cod_prestamo { get; set; }
        public int cod_libro { get; set; }
        public int cod_usuario { get; set; }
        public System.DateTime fecha_salida { get; set; }
        public System.DateTime fecha_maxima { get; set; }
        public System.DateTime fecha_devolucion { get; set; }
    
        public virtual Libro Libro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
