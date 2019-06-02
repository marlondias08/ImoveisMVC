using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImoveisMVC.Models;
namespace ImoveisMVC.Controllers
{
    public class ImovelController : Controller
    {
        private readonly SolutionContext _context;

        public ImovelController(SolutionContext context)
        {
            _context = context;
        }        

        public ActionResult Index(string sortOrder, string searchString)
        {
            if (String.IsNullOrEmpty(sortOrder))
                sortOrder = "DscImovel_desc";
            //Ordenar lista de imóveis
            ViewBag.DscSortParm = sortOrder == "DscImovel" ? "DscImovel_desc" : "DscImovel";
            ViewBag.VlrSortParm = sortOrder == "VlrImovel" ? "VlrImovel_desc" : "VlrImovel";
            ViewBag.QrtSortParm = sortOrder == "NumQrtImovel" ? "NumQrtImovel_desc" : "NumQrtImovel";
            ViewBag.VagSortParm = sortOrder == "NumVagImovel" ? "NumVagImovel_desc" : "NumVagImovel";
            ViewBag.TipSortParm = sortOrder == "TipImovel" ? "TipImovel_desc" : "TipImovel";
            ViewBag.BroSortParm = sortOrder == "BroImovel" ? "BroImovel_desc" : "BroImovel";
            ViewBag.CddSortParm = sortOrder == "CddImovel" ? "CddImovel_desc" : "CddImovel"; 
            ViewBag.UFSortParm = sortOrder == "UFImovel" ? "UFImovel_desc" : "UFImovel";
            ViewBag.RuaSortParm = sortOrder == "Logradouro" ? "Logradouro_desc" : "Logradouro";

            var imoveis = from s in _context.ImovelModel
                           select s;

            switch (sortOrder)
            {
                case "DscImovel":
                    imoveis = imoveis.OrderBy(s => s.DscImovel);
                    break;
                case "DscImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.DscImovel);
                    break;
                case "VlrImovel":
                    imoveis = imoveis.OrderBy(s => s.VlrImovel);
                    break;
                case "VlrImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.VlrImovel);
                    break;
                case "NumQrtImovel":
                    imoveis = imoveis.OrderBy(s => s.NumQrtImovel);
                    break;
                case "NumQrtImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.NumQrtImovel);
                    break;
                case "NumVagImovel":
                    imoveis = imoveis.OrderBy(s => s.NumVagImovel);
                    break;
                case "NumVagImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.NumVagImovel);
                    break;
                case "TipImovel":
                    imoveis = imoveis.OrderBy(s => s.TipImovel);
                    break;
                case "TipImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.TipImovel);
                    break;
                case "BroImovel":
                    imoveis = imoveis.OrderBy(s => s.BroImovel);
                    break;
                case "BroImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.BroImovel);
                    break;
                case "CddImovel":
                    imoveis = imoveis.OrderBy(s => s.CddImovel);
                    break;
                case "CddImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.CddImovel);
                    break;
                case "UFImovel":
                    imoveis = imoveis.OrderBy(s => s.UFImovel);
                    break;
                case "UFImovel_desc":
                    imoveis = imoveis.OrderByDescending(s => s.UFImovel);
                    break;
                case "Logradouro":
                    imoveis = imoveis.OrderBy(s => s.RuaImovel);
                    break;
                case "Logradouro_desc":
                    imoveis = imoveis.OrderByDescending(s => s.RuaImovel);
                    break;
            }

            //Pesquisa
            if (!String.IsNullOrEmpty(searchString))
            {
                imoveis = imoveis.Where(s => s.DscImovel.Contains(searchString)
                                       || s.CddImovel.Contains(searchString)
                                       || s.BroImovel.Contains(searchString)
                                       || s.UFImovel.Contains(searchString)
                                       || s.RuaImovel.Contains(searchString)
                                       );
            }
            
            return View(imoveis.ToList());
        }

        // GET: Imovel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imovelModel = await _context.ImovelModel
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovelModel == null)
            {
                return NotFound();
            }

            return View(imovelModel);
        }

        // GET: Imovel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imovel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdImovel,DscImovel,VlrImovel,NumQrtImovel,NumVagImovel,TipImovel,RuaImovel,BroImovel,CddImovel,UFImovel,CEPImovel")] ImovelModel imovelModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imovelModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imovelModel);
        }

        // GET: Imovel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imovelModel = await _context.ImovelModel.FindAsync(id);
            if (imovelModel == null)
            {
                return NotFound();
            }
            return View(imovelModel);
        }

        // POST: Imovel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdImovel,DscImovel,VlrImovel,NumQrtImovel,NumVagImovel,TipImovel,RuaImovel,BroImovel,CddImovel,UFImovel,CEPImovel")] ImovelModel imovelModel)
        {
            if (id != imovelModel.IdImovel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imovelModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImovelModelExists(imovelModel.IdImovel))
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
            return View(imovelModel);
        }

        // GET: Imovel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imovelModel = await _context.ImovelModel
                .FirstOrDefaultAsync(m => m.IdImovel == id);
            if (imovelModel == null)
            {
                return NotFound();
            }

            return View(imovelModel);
        }

        // POST: Imovel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imovelModel = await _context.ImovelModel.FindAsync(id);
            _context.ImovelModel.Remove(imovelModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImovelModelExists(int id)
        {
            return _context.ImovelModel.Any(e => e.IdImovel == id);
        }
    }
}
