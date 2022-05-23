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
                    TenSP = "PC Văn phòng",
                    CauHinh = "CPU: i3-10105, Card:(Trống) , RAM: 8GB, SSD: 240GB,PSU: 200W ",
                    SoLuong = 1,
                    GiaTien = 10200000,
                    ProfilePicture = "https://product.hstatic.net/1000026716/product/homework_mini_i3_d53bdfa4199d4d6da32be982e6094be2.jpg"
                },
                new DonHang
                {
                    TenSP = "PC Gaming",
                    CauHinh = "CPU: i5-11400F, Card: RTX 2060, RAM: 8GB, SSD: 240GB,PSU: 650W ",
                    SoLuong = 1,
                    GiaTien = 22500000,
                    ProfilePicture = "https://product.hstatic.net/1000026716/product/ghost_3dedb620811c4c25935ffb5df0dbec71.jpg"
                },
                new DonHang
                {
                    TenSP = "PC Mini",
                    CauHinh = "CPU: i3-10110U, Card: Intel® Core™ UHD, RAM: 4GB, SSD: 120GB, ",
                    SoLuong = 1,
                    GiaTien = 9500000,
                    ProfilePicture = "https://product.hstatic.net/1000026716/product/3_7e027c39122d40069c0bcef65a7694b1_4a8f88da7f7b4ad499b9ac6b6854716b.png"
                },

                new DonHang
                {
                    TenSP = "PC Workstation",
                    CauHinh = "CPU: i5-12600KF, Card: RTX 3060 Dual 12GB, RAM: 16GB, SSD: 500GB, ",
                    SoLuong = 1,
                    GiaTien = 32500000,
                    ProfilePicture = "https://product.hstatic.net/1000026716/product/neon_91c0996086374bab98d8bd3a16162cf9.jpg"
                }   
                    );
                    context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}