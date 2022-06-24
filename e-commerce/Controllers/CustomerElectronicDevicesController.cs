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
    public class CustomerElectronicDevicesController : Controller
    {
        private readonly ShoppingDbContext _context;
        HttpClient client = new HttpClient();
        private readonly string ElectronicDeviceURL = ApiURLS.GetElectronicDevicesUrl();

        public CustomerElectronicDevicesController(ShoppingDbContext context)
        {
            _context = context;
        }

        // GET: CustomerElectronicDevices
        public async Task<IActionResult> Index()
        {

            //return View(await _context.ElectronicDevice.ToListAsync());
            return View(JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicDeviceURL)).ToList());
        }

        public async Task<IActionResult> Laptop()
        {
            var LaptopList = JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicDeviceURL)).ToList();


            return View(LaptopList.Where(a => a.Category.Equals(Category.Laptop)));
        }

        public async Task<IActionResult> EList()
        {
            return View(JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicDeviceURL)).ToList());
        }

        public async Task<IActionResult> Mobile()
        {
            var MobileList = JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicDeviceURL)).ToList();

            return View(MobileList.Where(a => a.Category.Equals(Category.Mobile)));
       
    }

        // GET: CustomerElectronicDevices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var electronicDevice = await _context.ElectronicDevice
            //  .FirstOrDefaultAsync(m => m.EId == id);
            var electronicDevice = JsonConvert.DeserializeObject<ElectronicDevice>(await client.GetStringAsync(ElectronicDeviceURL + id));
            HttpContext.Session.SetString("CEId", electronicDevice.EId.ToString());
            if (electronicDevice == null)
            {
                return NotFound();
            }

            return View(electronicDevice);
        }

        // GET: CustomerElectronicDevices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerElectronicDevices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EId,EName,Category,Price,Quantity,Rating,LaunchDate,ImageFile,EBrand,Description,FreeDelivery,Active")] ElectronicDevice electronicDevice)
        {
            if (ModelState.IsValid)
            {
                //  _context.Add(electronicDevice);
                // await _context.SaveChangesAsync();
                await client.PostAsJsonAsync<ElectronicDevice>(ElectronicDeviceURL, electronicDevice);
                return RedirectToAction(nameof(Index));
            }
            return View(electronicDevice);
        }

        // GET: CustomerElectronicDevices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var electronicDevice = await _context.ElectronicDevice.FindAsync(id);
            var electronicDevice = JsonConvert.DeserializeObject<ElectronicDevice>(await client.GetStringAsync(ElectronicDeviceURL + id));

            if (electronicDevice == null)
            {
                return NotFound();
            }
            return View(electronicDevice);
        }

        // POST: CustomerElectronicDevices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EId,EName,Category,Price,Quantity,Rating,LaunchDate,ImageFile,EBrand,Description,FreeDelivery,Active")] ElectronicDevice electronicDevice)
        {
            if (id != electronicDevice.EId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(electronicDevice);
                    // await _context.SaveChangesAsync();
                    await client.PutAsJsonAsync<ElectronicDevice>(ElectronicDeviceURL + id, electronicDevice);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var electronicDeviced = JsonConvert.DeserializeObject<ElectronicDevice>(await client.GetStringAsync(ElectronicDeviceURL + id));

                    if (!(electronicDeviced.EId== electronicDevice.EId))
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
            return View(electronicDevice);
        }

        // GET: CustomerElectronicDevices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var electronicDevice = await _context.ElectronicDevice
            //.FirstOrDefaultAsync(m => m.EId == id);
            var electronicDevice = JsonConvert.DeserializeObject<ElectronicDevice>(await client.GetStringAsync(ElectronicDeviceURL + id));
            if (electronicDevice == null)
            {
                return NotFound();
            }

            return View(electronicDevice);
        }

        // POST: CustomerElectronicDevices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
          //  var electronicDevice = await _context.ElectronicDevice.FindAsync(id);
            // _context.ElectronicDevice.Remove(electronicDevice);
            // await _context.SaveChangesAsync();
            await client.DeleteAsync(ElectronicDeviceURL + id);
            return RedirectToAction(nameof(Index));
        }

        private bool ElectronicDeviceExists(int id)
        {
            return _context.ElectronicDevice.Any(e => e.EId == id);
        }
    }
}
