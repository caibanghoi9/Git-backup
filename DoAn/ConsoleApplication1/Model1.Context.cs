﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NganHangEntities : DbContext
    {
        public NganHangEntities()
            : base("name=NganHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiNhanhNganHang> ChiNhanhNganHangs { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<CreditCard_history> CreditCard_history { get; set; }
        public virtual DbSet<DebitCard> DebitCards { get; set; }
        public virtual DbSet<DebitCard_history> DebitCard_history { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichSuGiaoDich> LichSuGiaoDiches { get; set; }
        public virtual DbSet<LoaiGiaoDich> LoaiGiaoDiches { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiSoTietKiem> LoaiSoTietKiems { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuChuyenTien> PhieuChuyenTiens { get; set; }
        public virtual DbSet<PhieuGuiTien> PhieuGuiTiens { get; set; }
        public virtual DbSet<PhieuNopTienVaoSoTietKiem> PhieuNopTienVaoSoTietKiems { get; set; }
        public virtual DbSet<PhieuRutTien> PhieuRutTiens { get; set; }
        public virtual DbSet<SoTietKiem> SoTietKiems { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThamSo> ThamSoes { get; set; }
        public virtual DbSet<TruSoNganHang> TruSoNganHangs { get; set; }
    }
}
