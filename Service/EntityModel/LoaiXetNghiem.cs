//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiXetNghiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiXetNghiem()
        {
            this.BenhAn_LoaiXetNghiem = new HashSet<BenhAn_LoaiXetNghiem>();
            this.MauBenhAn_LoaiXetNghiem = new HashSet<MauBenhAn_LoaiXetNghiem>();
            this.ThangDoiChieux = new HashSet<ThangDoiChieu>();
        }
    
        public int id { get; set; }
        public string TenLoaiXetNghiem { get; set; }
        public string TenHienThi { get; set; }
        public string DonVi { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhAn_LoaiXetNghiem> BenhAn_LoaiXetNghiem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MauBenhAn_LoaiXetNghiem> MauBenhAn_LoaiXetNghiem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThangDoiChieu> ThangDoiChieux { get; set; }
    }
}