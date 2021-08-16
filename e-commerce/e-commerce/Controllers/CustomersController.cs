using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_commerce.Context;
using e_commerce.Models;
using e_commerce.ViewModel;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace e_commerce.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ShoppingDbContext _context;
        HttpClient client = new HttpClient();
        string CustomerURL = "https://localhost:44366/api/Customers/";

        public CustomersController(ShoppingDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {

            return View(JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList());
        }

        public IActionResult ForgotPassword()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            var customerobj = customerList.FirstOrDefault(a => a.Email.Equals(forgetPasswordViewModel.EmailId));
            //var customerobj = _context.Customer.FirstOrDefault(a => a.Email.Equals(forgetPasswordViewModel.EmailId));
            if (customerobj != null)
            {
                if(forgetPasswordViewModel.NewPassword == forgetPasswordViewModel.ConfirmPassword)
                {
                    customerobj.Password = forgetPasswordViewModel.NewPassword;
                    customerobj.ConfirmPassword = forgetPasswordViewModel.ConfirmPassword;
                    
                    await client.PutAsJsonAsync<Customer>(CustomerURL + customerobj.UserId, customerobj);
                    //_context.Customer.Update(customerobj);
                    //_context.SaveChanges();
                    return RedirectToAction("Customer", "Login");
                }
                else
                {
                    ModelState.AddModelError("Error", "Please check Confirm Password");
                }
               

            }
            else
            {
                ModelState.AddModelError("Error", "Please Enter Registered Email Address");
            }
            return View(forgetPasswordViewModel);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var customer = await _context.Customer
            // .FirstOrDefaultAsync(m => m.UserId == id);
            var customer = JsonConvert.DeserializeObject<Customer>(await client.GetStringAsync(CustomerURL + id));
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,Email,UserName,Password,ConfirmPassword,Balance")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(customer);
                //await _context.SaveChangesAsync();
                await client.PostAsJsonAsync<Customer>(CustomerURL, customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var customer = await _context.Customer.FindAsync(id);
            var customer = JsonConvert.DeserializeObject<Customer>(await client.GetStringAsync(CustomerURL + id));
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,Email,UserName,Password,ConfirmPassword,Balance")] Customer customer)
        {
            if (id != customer.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(customer);
                    //await _context.SaveChangesAsync();
                    await client.PutAsJsonAsync<Customer>(CustomerURL + id, customer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("CMyAccount","Login");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var customer = await _context.Customer
            // .FirstOrDefaultAsync(m => m.UserId == id);
            var customer = JsonConvert.DeserializeObject<Customer>(await client.GetStringAsync(CustomerURL + id));

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // var customer = await _context.Customer.FindAsync(id);
            //_context.Customer.Remove(customer);
            //await _context.SaveChangesAsync();
            await client.DeleteAsync(CustomerURL + id);
            return RedirectToAction("CMyAccount","Login");
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.UserId == id);
        }
    }
}
