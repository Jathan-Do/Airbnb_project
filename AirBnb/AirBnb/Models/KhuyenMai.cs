//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirBnb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuyenMai()
        {
            this.Phongs = new HashSet<Phong>();
        }
    
        public int MaKM { get; set; }
        public string TenKM { get; set; }
        public System.DateTime NgayBD { get; set; }
        public System.DateTime NgayKT { get; set; }
        public decimal UuDai { get; set; }
        public int MaChuNha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
        public virtual ChuNha ChuNha { get; set; }
    }
}
