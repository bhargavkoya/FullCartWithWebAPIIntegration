using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_commerce.Context;
using e_commerce.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace e_commerce.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly ShoppingDbContext _context;
        HttpClient client = new HttpClient();
        private readonly string PaymentURL = ApiURLS.GetPaymentUrl();

        public PaymentsController(ShoppingDbContext context)
        {
            _context = context;
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username1") != null)
            {
                var shoppingDbContext = JsonConvert.DeserializeObject<List<Payment>>(await client.GetStringAsync(PaymentURL)).ToList().Where(a => a.CardHolderName.ToLower().Equals(HttpContext.Session.GetString("username1").ToLower()));
                //  var shoppingDbContext = _context.Payment.Where(a => a.CardHolderName.ToLower().Equals(HttpContext.Session.GetString("username1").ToLower()));
                var count = shoppingDbContext.ToList().Count();
                if (shoppingDbContext != null && count > 0)
                {
                    return View(shoppingDbContext.ToList());
                }
                else
                {
                    return RedirectToAction("Create");
                }

            }
            else
            {
                return RedirectToAction("Customer", "Login");
            }
        }

        // GET: Payments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var payment = await _context.Payment
            // .FirstOrDefaultAsync(m => m.PId == id);
            var payment = JsonConvert.DeserializeObject<Payment>(await client.GetStringAsync(PaymentURL + id));
            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }

        // GET: Payments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,CardNumber,Password,CardHolderName,Balance")] Payment payment)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(payment);
                //await _context.SaveChangesAsync();
                await client.PostAsJsonAsync<Payment>(PaymentURL, payment);
                return RedirectToAction(nameof(Index));
            }
            return View(payment);
        }

        // GET: Payments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //  var payment = await _context.Payment.FindAsync(id);
            var payment = JsonConvert.DeserializeObject<Payment>(await client.GetStringAsync(PaymentURL + id));
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PId,CardNumber,Password,CardHolderName,Balance")] Payment payment)
        {
            if (id != payment.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(payment);
                    // await _context.SaveChangesAsync();
                    await client.PutAsJsonAsync<Payment>(PaymentURL + id, payment);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var payments = JsonConvert.DeserializeObject<Payment>(await client.GetStringAsync(PaymentURL + id));
                    if (!(payments.PId== payment.PId))
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
            return View(payment);
        }

        // GET: Payments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var payment = await _context.Payment
            //.FirstOrDefaultAsync(m => m.PId == id);
            var payment = JsonConvert.DeserializeObject<Payment>(await client.GetStringAsync(PaymentURL + id));
            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }

        // POST: Payments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var payment = await _context.Payment.FindAsync(id);
            // _context.Payment.Remove(payment);
            // await _context.SaveChangesAsync();
            await client.DeleteAsync(PaymentURL + id);
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentExists(int id)
        {
            return _context.Payment.Any(e => e.PId == id);
        }
    }
}
