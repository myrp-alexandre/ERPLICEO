//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_factura_x_fa_guia_remision
    {
        public int fa_IdEmpresa { get; set; }
        public int fa_IdSucursal { get; set; }
        public int fa_IdBodega { get; set; }
        public decimal fa_IdCbteVta { get; set; }
        public int gi_IdEmpresa { get; set; }
        public int gi_IdSucursal { get; set; }
        public int gi_IdBodega { get; set; }
        public decimal gi_IdGuiaRemision { get; set; }
        public string Observacion { get; set; }
    
        public virtual fa_guia_remision fa_guia_remision { get; set; }
        public virtual fa_factura fa_factura { get; set; }
    }
}