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
    
    public partial class cp_nota_DebCre
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Nota { get; set; }
        public int IdTipoCbte_Nota { get; set; }
        public string DebCre { get; set; }
        public string IdTipoNota { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdSucursal { get; set; }
        public System.DateTime cn_fecha { get; set; }
        public Nullable<System.DateTime> Fecha_contable { get; set; }
        public System.DateTime cn_Fecha_vcto { get; set; }
        public string cn_serie1 { get; set; }
        public string cn_serie2 { get; set; }
        public string cn_Nota { get; set; }
        public string cn_observacion { get; set; }
        public double cn_subtotal_iva { get; set; }
        public double cn_subtotal_siniva { get; set; }
        public double cn_baseImponible { get; set; }
        public double cn_Por_iva { get; set; }
        public double cn_valoriva { get; set; }
        public double cn_Ice_base { get; set; }
        public double cn_Ice_por { get; set; }
        public double cn_Ice_valor { get; set; }
        public double cn_Serv_por { get; set; }
        public double cn_Serv_valor { get; set; }
        public decimal cn_BaseSeguro { get; set; }
        public decimal cn_total { get; set; }
        public string cn_vaCoa { get; set; }
        public string cn_Autorizacion { get; set; }
        public string cn_num_doc_modificado { get; set; }
        public Nullable<int> IdCod_ICE { get; set; }
        public string IdTipoServicio { get; set; }
        public Nullable<int> IdIden_credito { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string cn_tipoLocacion { get; set; }
        public string PagoLocExt { get; set; }
        public string PaisPago { get; set; }
        public string ConvenioTributacion { get; set; }
        public string PagoSujetoRetencion { get; set; }
        public Nullable<System.DateTime> fecha_autorizacion { get; set; }
        public string cod_nota { get; set; }
    
        public virtual cp_codigo_SRI cp_codigo_SRI { get; set; }
        public virtual cp_codigo_SRI cp_codigo_SRI1 { get; set; }
        public virtual cp_proveedor cp_proveedor { get; set; }
    }
}
