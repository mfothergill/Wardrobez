//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wardrobez.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sho()
        {
            this.Outfits = new HashSet<Outfit>();
        }
    
        public int ShoeID { get; set; }
        public string ShoeName { get; set; }
        public string ShoePhoto { get; set; }
        public string ShoeType { get; set; }
        public string ShoeColor { get; set; }
        public string ShoeSeason { get; set; }
        public string ShoeOccasion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outfit> Outfits { get; set; }
    }
}
