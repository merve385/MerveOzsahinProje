using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BauToDoList.Models;

namespace BauToDoList.Controllers
{
    public class CustomersController : Controller
    {
        private appDbContext db = new appDbContext();

        // GET: Customers
        public async Task<ActionResult> Index()//async sayfa yüklenirken arkadan veri çekmesini sağlar
        {
            return View(await db.Customers.ToListAsync());//database balan mşteri tablosuna git ve listele ve görünme ysni view geri gönder 
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(int? id)//detayda listenin tamamına değil ıd ye ihtiyac var
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//ıd null getirirsem bag request sayfasına git
            }
            Customer customer = await db.Customers.FindAsync(id);//olmayan bir kaydı getirmek istediğimde not found sayfasına gitsin
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);//bu bilgileri detailsin viewine taşıdı
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            var customer = new Customer();
            return View(customer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Email,Phone,Fax,WebSite,Address,CreatedBy,CreateDate,UpdatedBy,UpdateDate")] Customer customer)
        {
            if (ModelState.IsValid)//modelden gelen bilgilerin uygunluğuna bakıyor eksik gelirse  işlem yapmıyor
            {
                customer.CreateDate = DateTime.Now;
                customer.CreatedBy = User.Identity.Name;
                customer.UpdateDate = DateTime.Now;
                customer.UpdatedBy = User.Identity.Name;

                db.Customers.Add(customer);//customer tablosuna ekliyor
                await db.SaveChangesAsync();//onay alıyo
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Email,Phone,Fax,WebSite,Address,CreatedBy,CreateDate,UpdatedBy,UpdateDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.UpdateDate = DateTime.Now;
                customer.UpdatedBy = User.Identity.Name;

                db.Entry(customer).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Customer customer = await db.Customers.FindAsync(id);
            db.Customers.Remove(customer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
