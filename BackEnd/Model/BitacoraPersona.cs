
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BackEnd.Model
{

using System;
    using System.Collections.Generic;
    
public partial class BitacoraPersona
{

    public int idBitacora { get; set; }

    public int idUsuario { get; set; }

    public int tipoMovimiento { get; set; }

    public System.DateTime fecha { get; set; }

    public int idPersona { get; set; }

    public int idTipo { get; set; }

    public string cedula { get; set; }

    public string nombreCompleto { get; set; }

    public string RepresentanteSocial { get; set; }

    public string RepresentanteLegal { get; set; }

    public string correo { get; set; }

    public string observacion { get; set; }

    public string observacionBitacora { get; set; }



    public virtual TablaGeneral TablaGeneral { get; set; }

    public virtual Usuario Usuario { get; set; }

}

}
