//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransitoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA_TRAMITE
    {
        public decimal ID_FACTURA { get; set; }
        public decimal ID_TRAMITE { get; set; }
        public Nullable<System.DateTime> CREA_FECHA { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual TRAMITE TRAMITE { get; set; }
    }
}
