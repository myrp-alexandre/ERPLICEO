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
    
    public partial class ro_empleado_x_rubro_acumulado
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> Fec_Inicio_Acumulacion { get; set; }
        public Nullable<System.DateTime> Fec_Fin_Acumulacion { get; set; }
    
        public virtual ro_empleado ro_empleado { get; set; }
        public virtual ro_rubro_tipo ro_rubro_tipo { get; set; }
    }
}
