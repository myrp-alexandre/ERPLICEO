//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwpro_FabricacionDet
    {
        public int IdEmpresa { get; set; }
        public decimal IdFabricacion { get; set; }
        public int Secuencia { get; set; }
        public string Signo { get; set; }
        public decimal IdProducto { get; set; }
        public string IdUnidadMedida { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public bool RealizaMovimiento { get; set; }
        public string pr_descripcion { get; set; }
        public string tp_ManejaInven { get; set; }
        public Nullable<bool> se_distribuye { get; set; }
    }
}