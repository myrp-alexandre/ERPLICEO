//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_ordencompra_local_detPorIngresar
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public string Tipo { get; set; }
        public int SecuenciaTipo { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioFinal { get; set; }
        public double CantidadIngresada { get; set; }
        public double Saldo { get; set; }
        public string IdUnidadMedida { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string oc_observacion { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public decimal IdProveedor { get; set; }
    }
}
