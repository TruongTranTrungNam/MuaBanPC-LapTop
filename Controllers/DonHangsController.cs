using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuaBanPC_LapTop.Data;
using MuaBanPC_LapTop.Models;

namespace MuaBanPC_LapTop.Controllers
{
    public class DonHangsController : Controller
    {
        private readonly MuaBanPC_LapTopContext _context;

        public DonHangsController(MuaBanPC_LapTopContext context)
        {
            _context = context;
        }

        // GET: DonHangs
        public async Task<IActionResult> Index(string searchString)
        {
            var donhang = from b in _context.DonHang
                        select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                donhang = donhang.Where(s => s.TenSP!.Contains(searchString));
            }
            return View(await donhang.ToListAsync());  
        }

        //Trang chủ sp  Nguời dùng (Userindex)
        public async Task<IActionResult> UserIndex(string searchString)
        {
            var donhang = from b in _context.DonHang
                          select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                donhang = donhang.Where(s => s.TenSP!.Contains(searchString));
            }
            return View(await donhang.ToListAsync());
        }
        public async Task<IActionResult> trangchu1(string searchString)
        {
            var donhang = from b in _context.DonHang
                          select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                donhang = donhang.Where(s => s.TenSP!.Contains(searchString));
            }
            return View(await donhang.ToListAsync());
        }

        // GET: DonHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHang
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donHang == null)
            {
                return NotFound();
            }

            return View(donHang);
        }



        //Chi tiết sp người dùng (UserDetails)
        public async Task<IActionResult> UserDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHang
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donHang == null)
            {
                return NotFound();
            }

            return View(donHang);
        }
        // GET: DonHangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenSP,NgayMua,SoLuong,GiaTien")] DonHang donHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donHang);
        }

        // GET: DonHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHang.FindAsync(id);
            if (donHang == null)
            {
                return NotFound();
            }
            return View(donHang);
        }

        // POST: DonHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenSP,NgayMua,SoLuong,GiaTien")] DonHang donHang)
        {
            if (id != donHang.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonHangExists(donHang.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(donHang);
        }

        // GET: DonHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donHang = await _context.DonHang
                .FirstOrDefaultAsync(m => m.Id == id);
            if (donHang == null)
            {
                return NotFound();
            }

            return View(donHang);
        }

        // POST: DonHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donHang = await _context.DonHang.FindAsync(id);
            _context.DonHang.Remove(donHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonHangExists(int id)
        {
            return _context.DonHang.Any(e => e.Id == id);
        }
    }
}
