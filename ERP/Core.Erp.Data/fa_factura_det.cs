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
    
    public partial class fa_factura_det
    {
        public fa_factura_det()
        {
            this.fa_CambioProductoDet = new HashSet<fa_CambioProductoDet>();
            this.fa_guia_remision_det_x_factura = new HashSet<fa_guia_remision_det_x_factura>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_DescUnitario { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double vt_total { get; set; }
        public string vt_detallexItems { get; set; }
        public double vt_por_iva { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public Nullable<int> IdEmpresa_pf { get; set; }
        public Nullable<int> IdSucursal_pf { get; set; }
        public Nullable<decimal> IdProforma { get; set; }
        public Nullable<int> Secuencia_pf { get; set; }
    
        public virtual ICollection<fa_CambioProductoDet> fa_CambioProductoDet { get; set; }
        public virtual fa_factura fa_factura { get; set; }
        public virtual fa_proforma_det fa_proforma_det { get; set; }
        public virtual ICollection<fa_guia_remision_det_x_factura> fa_guia_remision_det_x_factura { get; set; }
    }
}
