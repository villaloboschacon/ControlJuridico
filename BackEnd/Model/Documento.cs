
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
    
public partial class Documento
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Documento()
    {

        this.Adjuntos = new HashSet<Adjunto>();

        this.Destinatarios = new HashSet<Destinatario>();

        this.Casos = new HashSet<Caso>();

    }


    public int idDocumento { get; set; }

    public int idTipo { get; set; }

    public int idOrigen { get; set; }

    public int tipoOrigen { get; set; }

    public Nullable<int> idEstado { get; set; }

    public Nullable<long> idReferencia { get; set; }

    public string numeroDocumento { get; set; }

    public string numeroIngreso { get; set; }

    public System.DateTime fecha { get; set; }

    public string asunto { get; set; }

    public string descripcion { get; set; }

    public string ubicacion { get; set; }

    public string observacion { get; set; }

    public string parte { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Adjunto> Adjuntos { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Destinatario> Destinatarios { get; set; }

    public virtual TablaGeneral TablaGeneral { get; set; }

    public virtual TablaGeneral TablaGeneral1 { get; set; }

    public virtual TablaGeneral TablaGeneral2 { get; set; }

    public virtual TablaGeneral TablaGeneral3 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Caso> Casos { get; set; }

}

}
