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
    
    public partial class PhieuRutTien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuRutTien()
        {
            this.LichSuGiaoDiches = new HashSet<LichSuGiaoDich>();
        }
    
        public string MaPhieuRutTien { get; set; }
        public string SoTien { get; set; }
        public string NguoiRut { get; set; }
        public string NgayRut { get; set; }
        public string ChiNhanhThucHien { get; set; }
        public string NhanVienThucHien { get; set; }
        public string Status { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuGiaoDich> LichSuGiaoDiches { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
