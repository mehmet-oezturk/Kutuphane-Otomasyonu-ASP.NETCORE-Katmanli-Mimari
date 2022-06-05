using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kutuphaneDataAccess.Data;//bu ikisini ekledik
using KutuphaneModel;
using KutuphaneModel.Models;

namespace Kutuphane2ORMKatmanliCore.Controllers
{
    public class YazarlarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public YazarlarController(ApplicationDbContext db)// veri tabanı baglantıya baglanacak
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList = _db.Yazarlar.ToList();
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Yazarlar obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var ob = await _db.Yazarlar.FindAsync(id);
            return View(ob);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Yazarlar obj)
        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }
            var obj = await _db.Yazarlar.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Yazarlar.FindAsync(id);
            _db.Yazarlar.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
