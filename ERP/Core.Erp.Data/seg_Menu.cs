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
    
    public partial class seg_Menu
    {
        public seg_Menu()
        {
            this.seg_Menu_x_Empresa = new HashSet<seg_Menu_x_Empresa>();
            this.seg_usuario = new HashSet<seg_usuario>();
        }
    
        public int IdMenu { get; set; }
        public Nullable<int> IdMenuPadre { get; set; }
        public string DescripcionMenu { get; set; }
        public int PosicionMenu { get; set; }
        public bool Habilitado { get; set; }
        public bool Tiene_FormularioAsociado { get; set; }
        public string nom_Formulario { get; set; }
        public string nom_Asembly { get; set; }
        public Nullable<int> nivel { get; set; }
        public string web_nom_Area { get; set; }
        public string web_nom_Controller { get; set; }
        public string web_nom_Action { get; set; }
        public bool es_web { get; set; }
        public bool es_desktop { get; set; }
    
        public virtual ICollection<seg_Menu_x_Empresa> seg_Menu_x_Empresa { get; set; }
        public virtual ICollection<seg_usuario> seg_usuario { get; set; }
    }
}