using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NhanVienController : ApiController
    {
        [HttpGet]
        [Route("api/nhanvien/hello")]
        public IHttpActionResult hello()
        {
            
            using (NganHangEntities ctx = new NganHangEntities())
            {
                var list = ctx.NhanViens
                    .Select(c => new
                    {
                        c.MaNhanVien
                        
                    }).ToList();
                return Ok(list);
            }                
        }
        public static String TimNhanVien_TK_MK(String username,String password)
        {
            NganHangEntities ctx = new NganHangEntities();
            if (ctx.NhanViens.Any(o => (o.MaNhanVien == username && o.MatKhau == password)))
            {

            }
                return "";
        }

        [HttpPost]
        [Route("api/nhanvien/dangnhap")]
        public HttpResponseMessage DangNhap([FromBody]NhanVien nv)
        {
            NganHangEntities ctx = new NganHangEntities();
            if (ctx.NhanViens.Any(o => (o.TaiKhoan == nv.TaiKhoan && o.MatKhau == nv.MatKhau)))
            {
                var nv_output = ctx.NhanViens
                    .Select(c => new
                    {
                        c.HoTen,
                        c.DiaChi,
                        c.CMND,
                        c.GioiTinh,
                        c.SDT,
                        c.ThuocChiNhanh,
                        c.TaiKhoan,
                        c.MatKhau,
                        c.LoaiNhanVien,
                        c.Status
                    })
                    .Where(c => c.TaiKhoan == nv.TaiKhoan && c.MatKhau == nv.MatKhau)
                    .ToList();
                return Request.CreateResponse(HttpStatusCode.Created,nv_output);
            }
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
