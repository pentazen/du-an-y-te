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
    
    public partial class ChatUserDetailsRoom
    {
        public int id { get; set; }
        public string ConnectionId { get; set; }
        public Nullable<int> id_PhongThaoLuan { get; set; }
        public int id_ThanhVien { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual PhongThaoLuan PhongThaoLuan { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}