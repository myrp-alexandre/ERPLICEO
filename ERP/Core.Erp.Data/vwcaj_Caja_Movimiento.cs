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
    
    public partial class vwcaj_Caja_Movimiento
    {
        public int IdEmpresa { get; set; }
        public int IdTipocbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string cm_Signo { get; set; }
        public double cm_valor { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string Estado { get; set; }
        public string tm_descripcion { get; set; }
        public int IdCaja { get; set; }
        public string ca_Descripcion { get; set; }
        public Nullable<decimal> SecuenciaCaja { get; set; }
    }
}