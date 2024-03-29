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
    
    public partial class in_Catalogo
    {
        public in_Catalogo()
        {
            this.in_parametro = new HashSet<in_parametro>();
            this.in_parametro1 = new HashSet<in_parametro>();
            this.in_transferencia = new HashSet<in_transferencia>();
            this.in_Ajuste = new HashSet<in_Ajuste>();
            this.in_Motivo_Inven = new HashSet<in_Motivo_Inven>();
            this.in_movi_inven_tipo = new HashSet<in_movi_inven_tipo>();
        }
    
        public string IdCatalogo { get; set; }
        public int IdCatalogo_tipo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Orden { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaUltMod { get; set; }
    
        public virtual in_CatalogoTipo in_CatalogoTipo { get; set; }
        public virtual ICollection<in_parametro> in_parametro { get; set; }
        public virtual ICollection<in_parametro> in_parametro1 { get; set; }
        public virtual ICollection<in_transferencia> in_transferencia { get; set; }
        public virtual ICollection<in_Ajuste> in_Ajuste { get; set; }
        public virtual ICollection<in_Motivo_Inven> in_Motivo_Inven { get; set; }
        public virtual ICollection<in_movi_inven_tipo> in_movi_inven_tipo { get; set; }
    }
}
