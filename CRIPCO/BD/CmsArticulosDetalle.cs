//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRIPCO.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CmsArticulosDetalle
    {
        public int ArticuloDetalleId { get; set; }
        public int ArticuloId { get; set; }
        public byte[] Imagen { get; set; }
        public string UrlVideo { get; set; }
    
        public virtual CmsArticulo CmsArticulo { get; set; }
    }
}
