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
    
    public partial class DanhGia
    {
        public int MaDanhGia { get; set; }
        public string NoiDung { get; set; }
        public int MaPhong { get; set; }
        public int MaKH { get; set; }
        public Nullable<System.DateTime> NgayBL { get; set; }
    
        public virtual KhachThue KhachThue { get; set; }
        public virtual Phong Phong { get; set; }
    }
}
