using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MuaBanPC_LapTop.Data;
using System;
using System.Linq;
namespace MuaBanPC_LapTop.Models
{
    public static class XemDonHang
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MuaBanPC_LapTopContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MuaBanPC_LapTopContext>>()))
            {
                // Kiểm tra thông tin sản phẩm đã tồn tại hay chưa
                if (context.DonHang.Any())
                {
                    return; // Không thêm nếu sản phẩm đã tồn tại trong DB
                }
                context.DonHang.AddRange(
                new DonHang
                {
                    TenSP = "PC Gaming",
                    NgayMua = DateTime.Parse("2022-02-02"),
                    SoLuong = 1,
                    GiaTien = 22500000
                },
                new DonHang
                {
                    TenSP = "PC Mini",
                    NgayMua = DateTime.Parse("2021-08-03"),
                    SoLuong = 1,
                    GiaTien = 9500000
                },
                
                new DonHang
                {
                    TenSP = "PC Workstation",
                    NgayMua = DateTime.Parse("2021-08-03"),
                    SoLuong = 1,
                    GiaTien = 55200000
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}