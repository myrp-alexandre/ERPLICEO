//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class fa_proforma
    {
        public fa_proforma()
        {
            this.fa_proforma_det = new HashSet<fa_proforma_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProforma { get; set; }
        public decimal IdCliente { get; set; }
        public string IdTerminoPago { get; set; }
        public int pf_plazo { get; set; }
        public string pf_codigo { get; set; }
        public string pf_observacion { get; set; }
        public System.DateTime pf_fecha { get; set; }
        public System.DateTime pf_fecha_vcto { get; set; }
        public bool estado { get; set; }
        public string IdUsuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string IdUsuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string IdUsuario_anulacion { get; set; }
        public Nullable<System.DateTime> fecha_anulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public int IdBodega { get; set; }
        public int IdVendedor { get; set; }
        public int pr_dias_entrega { get; set; }
        public int IdNivel { get; set; }
        public string IdCatalogo_FormaPago { get; set; }
    
        public virtual fa_cliente fa_cliente { get; set; }
        public virtual fa_NivelDescuento fa_NivelDescuento { get; set; }
        public virtual fa_Vendedor fa_Vendedor { get; set; }
        public virtual ICollection<fa_proforma_det> fa_proforma_det { get; set; }
        public virtual fa_TerminoPago fa_TerminoPago { get; set; }
    }
}
