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
    
    public partial class MauBenhAn_LoaiXetNghiem
    {
        public int id_MauBenhAn { get; set; }
        public int id_LoaiXetNghiem { get; set; }
        public int ThuTu { get; set; }
    
        public virtual LoaiXetNghiem LoaiXetNghiem { get; set; }
        public virtual MauBenhAn MauBenhAn { get; set; }
    }
}
