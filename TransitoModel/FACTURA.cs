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
    
    public partial class FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURA()
        {
            this.TRAMITE = new HashSet<TRAMITE>();
        }
    
        public decimal ID { get; set; }
        public string NUMERO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> ID_VEHICULO { get; set; }
        public string OBSERVACIONES { get; set; }
    
        public virtual VEHICULO VEHICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAMITE> TRAMITE { get; set; }
    }
}