//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Model
{
    using System;
    
    public partial class SP_BuscaPersonaNombre_Result
    {
        public int idPersona { get; set; }
        public int idTipo { get; set; }
        public string cedula { get; set; }
        public string nombreCompleto { get; set; }
        public string RepresentanteSocial { get; set; }
        public string RepresentanteLegal { get; set; }
        public string correo { get; set; }
        public string observacion { get; set; }
        public Nullable<int> tipoIdentificacion { get; set; }
    }
}
