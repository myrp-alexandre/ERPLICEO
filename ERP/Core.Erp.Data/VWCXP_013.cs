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
    
    public partial class VWCXP_013
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public int Idsecuencia { get; set; }
        public string re_TipoRet { get; set; }
        public string co_factura { get; set; }
        public string NumRetencion { get; set; }
        public string TipoComprobante { get; set; }
        public System.DateTime FechaDeEmision { get; set; }
        public string EjercicioFiscal { get; set; }
        public double re_baseRetencion { get; set; }
        public double re_Porcen_retencion { get; set; }
        public double re_valor_retencion { get; set; }
        public string NombreProveedor { get; set; }
        public string pr_direccion { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pr_correo { get; set; }
        public string pr_telefonos { get; set; }
        public Nullable<System.DateTime> Fecha_Autorizacion { get; set; }
        public string NAutorizacion { get; set; }
        public string Su_Descripcion { get; set; }
    }
}