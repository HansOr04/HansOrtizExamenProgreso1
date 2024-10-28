using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HansOrtizExamenProgreso1.Models;

namespace HansOrtizExamenProgreso1.Controllers
{
    public class HO_ProductoController : Controller
    {
        private readonly HansOrtizExamenProgreso1Context _context;

        public HO_ProductoController(HansOrtizExamenProgreso1Context context)
        {
            _context = context;
        }

        // GET: HO_Producto
        
        public async Task<IActionResult> HO_Index()
        {
            return View(await _context.HO_Producto.ToListAsync());
        }

        // GET: HO_Producto/Details/5
        public async Task<IActionResult> HO_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hO_Producto = await _context.HO_Producto
                .FirstOrDefaultAsync(m => m.HO_ProductoId == id);
            if (hO_Producto == null)
            {
                return NotFound();
            }

            return View(hO_Producto);
        }

        // GET: HO_Producto/Create
        public IActionResult HO_Create()
        {
            return View();
        }

        // POST: HO_Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HO_Create([Bind("HO_ProductoId,HO_ProductoName,HO_ProductoDescripcion,HO_Price,HO_Variantes,HO_CreateAt")] HO_Producto hO_Producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hO_Producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(HO_Index));
            }
            return View(hO_Producto);
        }

        // GET: HO_Producto/Edit/5
        public async Task<IActionResult> HO_Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hO_Producto = await _context.HO_Producto.FindAsync(id);
            if (hO_Producto == null)
            {
                return NotFound();
            }
            return View(hO_Producto);
        }

        // POST: HO_Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HO_Edit(int id, [Bind("HO_ProductoId,HO_ProductoName,HO_ProductoDescripcion,HO_Price,HO_Variantes,HO_CreateAt")] HO_Producto hO_Producto)
        {
            if (id != hO_Producto.HO_ProductoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hO_Producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HO_ProductoExists(hO_Producto.HO_ProductoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(HO_Index));
            }
            return View(hO_Producto);
        }

        // GET: HO_Producto/Delete/5
        public async Task<IActionResult> HO_Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hO_Producto = await _context.HO_Producto
                .FirstOrDefaultAsync(m => m.HO_ProductoId == id);
            if (hO_Producto == null)
            {
                return NotFound();
            }

            return View(hO_Producto);
        }

        // POST: HO_Producto/Delete/5
        [HttpPost, ActionName("HO_Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HO_DeleteConfirmed(int id)
        {
            var hO_Producto = await _context.HO_Producto.FindAsync(id);
            if (hO_Producto != null)
            {
                _context.HO_Producto.Remove(hO_Producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HO_Index));
        }

        private bool HO_ProductoExists(int id)
        {
            return _context.HO_Producto.Any(e => e.HO_ProductoId == id);
        }
    }
}
