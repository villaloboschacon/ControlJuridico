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
    using System.Collections.Generic;
    
    public partial class BitacoraDestinatario
    {
        public int idBitacora { get; set; }
        public int idUsuario { get; set; }
        public int tipoMovimiento { get; set; }
        public System.DateTime fecha { get; set; }
        public int idDestinatario { get; set; }
        public int idDocumento { get; set; }
        public int idTipoDestino { get; set; }
        public int numeroDestinatario { get; set; }
        public string observacion { get; set; }
        public string observacionBitacora { get; set; }
    
        public virtual TablaGeneral TablaGeneral { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
