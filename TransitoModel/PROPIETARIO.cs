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
    
    public partial class PROPIETARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPIETARIO()
        {
            this.PROPIETARIO_VEHICULO = new HashSet<PROPIETARIO_VEHICULO>();
        }
    
        public decimal ID { get; set; }
        public string NUMEROIDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string CORREOELECTRONICO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPIETARIO_VEHICULO> PROPIETARIO_VEHICULO { get; set; }
    }
}
