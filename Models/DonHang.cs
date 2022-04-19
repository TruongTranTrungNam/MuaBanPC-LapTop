using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuaBanPC_LapTop.Models
{
    public class DonHang
    {
        public int Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [StringLength(30, ErrorMessage = "Không dài quá {1} kí tự và không dưới {2} kí tự", MinimumLength = 1)]
        [Required(ErrorMessage = "Không được để trống")]
        public string TenSP { get; set; }
        [Display(Name = "Ngày mua")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Không được để trống")]
        public DateTime NgayMua { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Không được để trống")]
        public int SoLuong { get; set; }
        [Display(Name = "Giá tiền")]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "Không được để trống")]

        public decimal GiaTien { get; set; }
    }
}
