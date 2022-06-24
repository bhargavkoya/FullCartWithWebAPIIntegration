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
    public class AddressesController : Controller
    {
        private readonly ShoppingDbContext _context;
        HttpClient client = new HttpClient();
        private readonly string AddressURL = ApiURLS.GetAddressUrl();
        private readonly string CustomerURL = ApiURLS.GetCustomerUrl();
       
        public AddressesController(ShoppingDbContext context)
        {
            _context = context;
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username1") != null)
            {
                var shoppingDbContext = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL)).ToList().Where(a => a.CustId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));
                //var shoppingDbContext = _context.Address.Include(c => c.Customer).Where(a => a.CustId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));
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

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var address = await _context.Address
            //  .Include(a => a.Customer)
            //.FirstOrDefaultAsync(m => m.AddressId == id);
            var address = JsonConvert.DeserializeObject<Address>(await client.GetStringAsync(AddressURL + id));
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // GET: Addresses/Create
        public async Task<IActionResult> Create()
        {
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            ViewBag.CustId = new SelectList(customerList, "UserId", "Email");
            return View();
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressId,FirstName,LastName,EmailAddress,PhoneNo,AddressLineone,AddressLinetwo,Country,City,State,PinCode,CustId")] Address address)
        {
            if (ModelState.IsValid)
            {
                // _context.Add(address);
                // await _context.SaveChangesAsync();
                await client.PostAsJsonAsync<Address>(AddressURL, address);
                return RedirectToAction(nameof(Index));
            }
           // var customerOBJ = _context.Address;
            var customerList = JsonConvert.DeserializeObject<DbSet<Customer>>(await client.GetStringAsync(CustomerURL));
            ViewData["CustId"] = new SelectList(customerList, "UserId", "Email", address.CustId);
            return View(address);
        }

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var address = await _context.Address.FindAsync(id);
            var address = JsonConvert.DeserializeObject<Address>(await client.GetStringAsync(AddressURL + id));
            if (address == null)
            {
                return NotFound();
            }
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            ViewData["CustId"] = new SelectList(customerList, "UserId", "Email", address.CustId);
            return View(address);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressId,FirstName,LastName,EmailAddress,PhoneNo,AddressLineone,AddressLinetwo,Country,City,State,PinCode,CustId")] Address address)
        {
            if (id != address.AddressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(address);
                    // await _context.SaveChangesAsync();
                    await client.PutAsJsonAsync<Address>(AddressURL + id, address);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var addresss = JsonConvert.DeserializeObject<Address>(await client.GetStringAsync(AddressURL + id));
                    if (!(addresss.AddressId== address.AddressId))
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
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            ViewData["CustId"] = new SelectList(customerList, "UserId", "Email", address.CustId);
            return View(address);
        }

        // GET: Addresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //  var address = await _context.Address
            //   .Include(a => a.Customer)
            //   .FirstOrDefaultAsync(m => m.AddressId == id);
            var address = JsonConvert.DeserializeObject<Address>(await client.GetStringAsync(AddressURL + id));
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // var address = await _context.Address.FindAsync(id);
            ////_context.Address.Remove(address);
            // await _context.SaveChangesAsync();
            await client.DeleteAsync(AddressURL + id);
            return RedirectToAction(nameof(Index));
        }

        private bool AddressExists(int id)
        {
            return _context.Address.Any(e => e.AddressId == id);
        }
    }
}
