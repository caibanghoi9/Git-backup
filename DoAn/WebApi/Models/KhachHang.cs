//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.CreditCards = new HashSet<CreditCard>();
            this.DebitCards = new HashSet<DebitCard>();
            this.PhieuChuyenTiens = new HashSet<PhieuChuyenTien>();
            this.PhieuChuyenTiens1 = new HashSet<PhieuChuyenTien>();
            this.PhieuGuiTiens = new HashSet<PhieuGuiTien>();
            this.PhieuRutTiens = new HashSet<PhieuRutTien>();
            this.SoTietKiems = new HashSet<SoTietKiem>();
        }
    
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> CMND { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<int> SoDu { get; set; }
        public string ChiNhanhMoTaiKhoan { get; set; }
        public string TaiKhoanDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Status { get; set; }
    
        public virtual ChiNhanhNganHang ChiNhanhNganHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitCard> DebitCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuChuyenTien> PhieuChuyenTiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuChuyenTien> PhieuChuyenTiens1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuGuiTien> PhieuGuiTiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuRutTien> PhieuRutTiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoTietKiem> SoTietKiems { get; set; }
    }
}
