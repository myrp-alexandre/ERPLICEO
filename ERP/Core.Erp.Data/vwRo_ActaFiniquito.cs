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
    
    public partial class vwRo_ActaFiniquito
    {
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdActaFiniquito { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdCausaTerminacion { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public double UltimaRemuneracion { get; set; }
        public string ObservacionFiniquito { get; set; }
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public string EstadoActa { get; set; }
        public Nullable<int> IdCodSectorial { get; set; }
        public bool EsMujerEmbarazada { get; set; }
        public bool EsDirigenteSindical { get; set; }
        public bool EsPorDiscapacidad { get; set; }
        public bool EsPorEnfermedadNoProfesional { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string em_codigo { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public string ca_descripcion { get; set; }
        public string Contrato { get; set; }
        public string CodCatalogo { get; set; }
        public string EstadoContrato { get; set; }
    }
}