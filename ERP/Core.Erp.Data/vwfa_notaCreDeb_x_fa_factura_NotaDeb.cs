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
    
    public partial class vwfa_notaCreDeb_x_fa_factura_NotaDeb
    {
        public int IdEmpresa_nt { get; set; }
        public int IdSucursal_nt { get; set; }
        public int IdBodega_nt { get; set; }
        public decimal IdNota_nt { get; set; }
        public int secuencia { get; set; }
        public string vt_tipoDoc { get; set; }
        public int IdEmpresa_fac_nd_doc_mod { get; set; }
        public int IdSucursal_fac_nd_doc_mod { get; set; }
        public int IdBodega_fac_nd_doc_mod { get; set; }
        public decimal IdCbteVta_fac_nd_doc_mod { get; set; }
        public double Valor_Aplicado { get; set; }
        public string vt_NumFactura { get; set; }
        public string vt_Observacion { get; set; }
        public string CodDoc { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public double ValorCobrado { get; set; }
        public double saldo { get; set; }
        public Nullable<double> saldo_sin_cobro { get; set; }
        public Nullable<System.DateTime> vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fech_venc { get; set; }
        public Nullable<decimal> IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
    }
}