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
    
    public partial class tb_CatalogoTipo
    {
        public tb_CatalogoTipo()
        {
            this.tb_Catalogo = new HashSet<tb_Catalogo>();
        }
    
        public int IdTipoCatalogo { get; set; }
        public string Codigo { get; set; }
        public string tc_Descripcion { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual ICollection<tb_Catalogo> tb_Catalogo { get; set; }
    }
}