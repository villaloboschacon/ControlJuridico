﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SCJ_BDEntities : DbContext
    {
        public SCJ_BDEntities()
            : base("name=SCJ_BDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adjunto> Adjuntos { get; set; }
        public virtual DbSet<BitacoraCaso> BitacoraCasos { get; set; }
        public virtual DbSet<BitacoraDestinatario> BitacoraDestinatarios { get; set; }
        public virtual DbSet<BitacoraDocumento> BitacoraDocumentos { get; set; }
        public virtual DbSet<BitacoraPersona> BitacoraPersonas { get; set; }
        public virtual DbSet<Caso> Casos { get; set; }
        public virtual DbSet<Destinatario> Destinatarios { get; set; }
        public virtual DbSet<Documento> Documentos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TablaGeneral> TablaGenerals { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Nullable<int>> getIdRolUsuario(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getIdRolUsuario", idUsuarioParameter);
        }
    
        public virtual ObjectResult<string> sp_getRolesForUser(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getRolesForUser", userNameParameter);
        }
    
        public virtual ObjectResult<Documento> sp_listaEntradas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_listaEntradas");
        }
    
        public virtual ObjectResult<Documento> sp_listaEntradas(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_listaEntradas", mergeOption);
        }
    
        public virtual ObjectResult<Documento> sp_listaSalidas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_listaSalidas");
        }
    
        public virtual ObjectResult<Documento> sp_listaSalidas(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_listaSalidas", mergeOption);
        }
    
        public virtual ObjectResult<Nullable<long>> sp_ConsultaNumerodeIngreso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("sp_ConsultaNumerodeIngreso");
        }
    
        public virtual ObjectResult<string> getNomenclatura(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getNomenclatura", nombreParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> sp_GeneraNumerodeIngreso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("sp_GeneraNumerodeIngreso");
        }
    
        public virtual ObjectResult<Persona> SP_BuscaPersonaNombre(string nombrePersona)
        {
            var nombrePersonaParameter = nombrePersona != null ?
                new ObjectParameter("NombrePersona", nombrePersona) :
                new ObjectParameter("NombrePersona", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Persona>("SP_BuscaPersonaNombre", nombrePersonaParameter);
        }
    
        public virtual ObjectResult<Persona> SP_BuscaPersonaNombre(string nombrePersona, MergeOption mergeOption)
        {
            var nombrePersonaParameter = nombrePersona != null ?
                new ObjectParameter("NombrePersona", nombrePersona) :
                new ObjectParameter("NombrePersona", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Persona>("SP_BuscaPersonaNombre", mergeOption, nombrePersonaParameter);
        }
    
        public virtual ObjectResult<Documento> sp_ListaReferencias(Nullable<long> idReferenciaB)
        {
            var idReferenciaBParameter = idReferenciaB.HasValue ?
                new ObjectParameter("idReferenciaB", idReferenciaB) :
                new ObjectParameter("idReferenciaB", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_ListaReferencias", idReferenciaBParameter);
        }
    
        public virtual ObjectResult<Documento> sp_ListaReferencias(Nullable<long> idReferenciaB, MergeOption mergeOption)
        {
            var idReferenciaBParameter = idReferenciaB.HasValue ?
                new ObjectParameter("idReferenciaB", idReferenciaB) :
                new ObjectParameter("idReferenciaB", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Documento>("sp_ListaReferencias", mergeOption, idReferenciaBParameter);
        }
    
        public virtual ObjectResult<string> sp_getUsuarioCorreo(Nullable<int> idUsuarioP)
        {
            var idUsuarioPParameter = idUsuarioP.HasValue ?
                new ObjectParameter("idUsuarioP", idUsuarioP) :
                new ObjectParameter("idUsuarioP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getUsuarioCorreo", idUsuarioPParameter);
        }
    
        public virtual int sp_archivaCaso(Nullable<int> idCasoP)
        {
            var idCasoPParameter = idCasoP.HasValue ?
                new ObjectParameter("idCasoP", idCasoP) :
                new ObjectParameter("idCasoP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_archivaCaso", idCasoPParameter);
        }
    
        public virtual int sp_archivaDocumento(Nullable<int> idDocumentoP)
        {
            var idDocumentoPParameter = idDocumentoP.HasValue ?
                new ObjectParameter("idDocumentoP", idDocumentoP) :
                new ObjectParameter("idDocumentoP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_archivaDocumento", idDocumentoPParameter);
        }
    
        public virtual ObjectResult<Nullable<long>> sp_GeneraNumerodeReferencia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("sp_GeneraNumerodeReferencia");
        }
    }
}
