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
    
    public partial class cxc_cobro
    {
        public cxc_cobro()
        {
            this.cxc_cobro_det = new HashSet<cxc_cobro_det>();
            this.cxc_cobro_x_ct_cbtecble = new HashSet<cxc_cobro_x_ct_cbtecble>();
            this.cxc_LiquidacionTarjeta_x_cxc_cobro = new HashSet<cxc_LiquidacionTarjeta_x_cxc_cobro>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public Nullable<decimal> IdCobro_a_aplicar { get; set; }
        public string cr_Codigo { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCliente { get; set; }
        public double cr_TotalCobro { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public System.DateTime cr_fechaDocu { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public string cr_estado { get; set; }
        public Nullable<decimal> cr_recibo { get; set; }
        public string cr_es_anticipo { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public int IdCaja { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<int> IdTipoNotaCredito { get; set; }
    
        public virtual ICollection<cxc_cobro_det> cxc_cobro_det { get; set; }
        public virtual ICollection<cxc_cobro_x_ct_cbtecble> cxc_cobro_x_ct_cbtecble { get; set; }
        public virtual cxc_cobro_tipo cxc_cobro_tipo { get; set; }
        public virtual ICollection<cxc_LiquidacionTarjeta_x_cxc_cobro> cxc_LiquidacionTarjeta_x_cxc_cobro { get; set; }
    }
}