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
    
    public partial class ro_cargaFamiliar
    {
        public int IdEmpresa { get; set; }
        public int IdCargaFamiliar { get; set; }
        public decimal IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string TipoFamiliar { get; set; }
        public string Nombres { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaDefucion { get; set; }
        public bool capacidades_especiales { get; set; }
    
        public virtual ro_catalogo ro_catalogo { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
    }
}