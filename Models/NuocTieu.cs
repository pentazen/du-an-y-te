//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NuocTieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NuocTieu()
        {
            this.NuocTieu_TapTin = new HashSet<NuocTieu_TapTin>();
        }
    
        public int id { get; set; }
        public int id_ThanhVien { get; set; }
        public string Duong { get; set; }
        public string SacToMauDaCam { get; set; }
        public string Ketone { get; set; }
        public string TyTrong { get; set; }
        public string Mau { get; set; }
        public string pH { get; set; }
        public string Dam { get; set; }
        public string Urobilinogen { get; set; }
        public string Nitrites { get; set; }
        public string TeBaoHongCau { get; set; }
        public string Leukocytes { get; set; }
        public string Ag_HBs { get; set; }
        public string Anti_HCV { get; set; }
        public string TrongLuongRieng { get; set; }
        public string ASC { get; set; }
        public string Ascorbic_Acid { get; set; }
        public string KetQua { get; set; }
        public string GhiChu { get; set; }
        public string KetQuaNgay { get; set; }
        public string NgayTao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NuocTieu_TapTin> NuocTieu_TapTin { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
