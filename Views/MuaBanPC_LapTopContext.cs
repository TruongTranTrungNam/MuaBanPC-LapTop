using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MuaBanPC_LapTop.Models;

namespace MuaBanPC_LapTop.Data
{
    public class MuaBanPC_LapTopContext : DbContext
    {
        public MuaBanPC_LapTopContext (DbContextOptions<MuaBanPC_LapTopContext> options)
            : base(options)
        {
        }

        public DbSet<MuaBanPC_LapTop.Models.DonHang> DonHang { get; set; }

        public DbSet<MuaBanPC_LapTop.Models.DMSP2> DMSP2 { get; set; }
    }
}
