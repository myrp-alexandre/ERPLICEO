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
    
    public partial class VWBAN_014
    {
        public int IdEmpresa_pago { get; set; }
        public int IdTipoCbte_pago { get; set; }
        public decimal IdCbteCble_pago { get; set; }
        public string TipoPago { get; set; }
        public string pe_nombreCompleto { get; set; }
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
        public string cb_Cheque { get; set; }
        public string BAN_Observacion { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<System.DateTime> CXP_Fecha { get; set; }
        public string CXP_Documento { get; set; }
        public string CXP_Observacion { get; set; }
        public double MontoAplicado { get; set; }
        public System.DateTime BAN_Fecha { get; set; }
        public Nullable<decimal> IdCbteCble_cxp { get; set; }
        public Nullable<int> IdTipoCbte_cxp { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
    }
}
