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
    
    public partial class imp_liquidacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacion { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public string li_num_documento { get; set; }
        public string li_codigo { get; set; }
        public string li_num_DAU { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string li_observacion { get; set; }
        public bool estado { get; set; }
        public Nullable<int> IdEmpresa_inv { get; set; }
        public Nullable<int> IdSucursal_inv { get; set; }
        public Nullable<int> IdMovi_inven_tipo_inv { get; set; }
        public Nullable<decimal> IdNumMovi_inv { get; set; }
        public Nullable<int> IdEmpresa_ct { get; set; }
        public Nullable<int> IdTipoCbte_ct { get; set; }
        public Nullable<decimal> IdCbteCble_ct { get; set; }
        public Nullable<int> IdBodega_inv { get; set; }
        public string IdUsuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string IdUsuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string IdUsuario_anulacion { get; set; }
        public Nullable<System.DateTime> fecha_anulacion { get; set; }
    
        public virtual imp_orden_compra_ext imp_orden_compra_ext { get; set; }
    }
}