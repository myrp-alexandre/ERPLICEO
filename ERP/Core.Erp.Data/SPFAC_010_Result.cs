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
    
    public partial class SPFAC_010_Result
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_NumFactura { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string NombreFormaPago { get; set; }
        public string IdCatalogo_FormaPago { get; set; }
        public string Estado { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public string Ve_Vendedor { get; set; }
        public string IdVendedor { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Telefonos { get; set; }
        public string Su_Direccion { get; set; }
        public string Su_Ruc { get; set; }
        public Nullable<decimal> SubtotalIVAConDscto { get; set; }
        public Nullable<decimal> SubtotalSinIVAConDscto { get; set; }
        public Nullable<decimal> ValorIVA { get; set; }
        public Nullable<decimal> Total { get; set; }
        public int FacturasEmitidas { get; set; }
        public int FacturasAnuladas { get; set; }
    }
}