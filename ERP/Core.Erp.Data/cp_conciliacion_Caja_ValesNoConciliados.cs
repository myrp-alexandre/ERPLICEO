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
    
    public partial class cp_conciliacion_Caja_ValesNoConciliados
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }
        public double Valor { get; set; }
    
        public virtual cp_conciliacion_Caja cp_conciliacion_Caja { get; set; }
    }
}