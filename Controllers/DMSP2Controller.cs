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
    public class DMSP2Controller : Controller
    {
        private readonly MuaBanPC_LapTopContext _context;

        public DMSP2Controller(MuaBanPC_LapTopContext context)
        {
            _context = context;
        }

        // GET: DMSP2
        public async Task<IActionResult> Index()
        {
            return View(await _context.DMSP2.ToListAsync());
        }

        // GET: DMSP2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMSP2 = await _context.DMSP2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dMSP2 == null)
            {
                return NotFound();
            }

            return View(dMSP2);
        }

        // GET: DMSP2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DMSP2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tensp,Giatien,Thongso")] DMSP2 dMSP2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dMSP2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dMSP2);
        }

        // GET: DMSP2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMSP2 = await _context.DMSP2.FindAsync(id);
            if (dMSP2 == null)
            {
                return NotFound();
            }
            return View(dMSP2);
        }

        // POST: DMSP2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tensp,Giatien,Thongso")] DMSP2 dMSP2)
        {
            if (id != dMSP2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dMSP2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DMSP2Exists(dMSP2.Id))
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
            return View(dMSP2);
        }

        // GET: DMSP2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dMSP2 = await _context.DMSP2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dMSP2 == null)
            {
                return NotFound();
            }

            return View(dMSP2);
        }

        // POST: DMSP2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dMSP2 = await _context.DMSP2.FindAsync(id);
            _context.DMSP2.Remove(dMSP2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DMSP2Exists(int id)
        {
            return _context.DMSP2.Any(e => e.Id == id);
        }
    }
}
