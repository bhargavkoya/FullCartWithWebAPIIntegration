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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using e_commerce.ViewModel;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace e_commerce.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ShoppingDbContext _context;
        HttpClient client = new HttpClient();
       
        private readonly string CustomerURL = ApiURLS.GetCustomerUrl();
        private readonly string ElectronicURL = ApiURLS.GetElectronicDevicesUrl();
        private readonly string  FashionURL = ApiURLS.GetFashionUrl();
        private readonly string HomeDecorURL = ApiURLS.GetHomeDecorUrl();
        private readonly string OrderReviewURL = ApiURLS.GetOrderReviewUrl();
        private readonly string PaymentURL = ApiURLS.GetPaymentUrl();
        private readonly string AddressURL = ApiURLS.GetAddressUrl();
        private readonly string CartURL =ApiURLS.GetCartUrl();
        private readonly string OrderURL = ApiURLS.GetOrderUrl();



        public OrdersController(ShoppingDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("username1") != null)
            {
                try
                {
                    var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL)).ToList();
                    var addressobj = AddressList.FirstOrDefault(a => a.CustId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));

                    var OrderList = JsonConvert.DeserializeObject<List<Order>>(await client.GetStringAsync(OrderURL));
                    var shoppingDbContext = OrderList.Where(a => a.AddrId.Equals(addressobj.AddressId)).ToList();

                    var count = shoppingDbContext.Count();
                    if (shoppingDbContext != null && count > 0)
                    {
                        return View(shoppingDbContext.ToList());
                    }
                }
                catch
                {
                    return RedirectToAction("OrderEmpty");
                }


            }

            else
            {
                return RedirectToAction("Customer", "Login");
            }
            return View();
           
           
        }
        [HttpPost]
        public async Task<IActionResult> GetDate(DateTime SD, DateTime ED)
        {
            var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL)).ToList();
            var addressobj = AddressList.FirstOrDefault(a => a.CustId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));

            var OrderList = JsonConvert.DeserializeObject<List<Order>>(await client.GetStringAsync(OrderURL)).ToList();
            var shoppingDbContext = OrderList.Where(a => a.AddrId.Equals(addressobj.AddressId)).Where(a=>a.DateOfOrder >= SD && a.DateOfOrder <= ED);
            return View("Index", shoppingDbContext.ToList());
        }

       /* [HttpPost] 
        public ActionResult GetDate(DateTime date1, DateTime date2)
        {
           // HttpContext.Session.SetString("fromDate", date1.ToString());
           // HttpContext.Session.SetString("endDate", date2.ToString());
            return RedirectToAction("Index");
        }*/

        
        public ActionResult OrderEmpty()
        {
            return View();

        }
        public async Task<IActionResult> PaymentProcess()
        {
            var CartList = JsonConvert.DeserializeObject<List<Cart>>(await client.GetStringAsync(CartURL)).ToList();
            var cartobj = CartList.Where(a => a.Userid.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));
            ViewBag.Amount = cartobj.ToList().Sum(a => a.Price * a.Quantity);
            ViewBag.CartList = cartobj;
            return View();
        }
        [HttpPost]
       
        public async Task<IActionResult> PaymentProcess([Bind("CardNumber,Password")] Payment payment)
        {
            var PaymentList = JsonConvert.DeserializeObject<List<Payment>>(await client.GetStringAsync(PaymentURL)).ToList();
            var paymentobj = PaymentList.FirstOrDefault(a => a.CardHolderName.ToLower().Equals(HttpContext.Session.GetString("username1").ToLower()));

            var CartList = JsonConvert.DeserializeObject<List<Cart>>(await client.GetStringAsync(CartURL)).ToList();
            var cartobj = CartList.Where(a => a.Userid.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));
            ViewBag.CartList = cartobj;
            ViewBag.Amount1 = cartobj.ToList().Sum(a => a.Price * a.Quantity);
            ViewBag.Amount2 = cartobj.ToList().Sum(a => (Convert.ToInt32(a.Price * a.Quantity)-(Convert.ToInt32(a.Price * a.Quantity*0.02))));

           
                if (paymentobj.CardNumber == payment.CardNumber && paymentobj.Password == payment.Password)
                {
                    if (paymentobj.Balance >= ViewBag.Amount1)
                    {

                        foreach (var item in cartobj)
                        {
                            if (item.Category == "Laptop" || item.Category == "Mobile" || item.Category == "EarPhone" || item.Category == "Camera" || item.Category == "Television" || item.Category == "Printers")
                            {
                                 var ElectronicDeviceList = JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicURL)).ToList();
                            var productobj = ElectronicDeviceList.FirstOrDefault(a => a.EName.Equals(item.productName));
                                productobj.Quantity = productobj.Quantity - item.Quantity;
                            // _context.ElectronicDevice.Update(productobj);
                            await client.PutAsJsonAsync<ElectronicDevice>(ElectronicURL + productobj.EId, productobj);

                        }
                            else if (item.Category == "Watch" || item.Category == "Wallet" || item.Category == "Sunglasses")
                            {
                                var FashionList = JsonConvert.DeserializeObject<List<Fashion>>(await client.GetStringAsync(FashionURL)).ToList();
                                var productobj1 = FashionList.FirstOrDefault(a => a.FName.Equals(item.productName));
                                productobj1.Quantity = productobj1.Quantity - item.Quantity;
                            // _context.Fashion.Update(productobj1);
                            await client.PutAsJsonAsync<Fashion>(FashionURL + productobj1.FId, productobj1);

                        }
                            else if (item.Category == "Furniture" || item.Category == "SecurityCameras" || item.Category == "SmartHomelightening" || item.Category == "Clocks" || item.Category == "Mirrors" || item.Category == "Wallpapers" || item.Category == "DreamCatcher")
                            {
                            var HomeDecorsList = JsonConvert.DeserializeObject<List<HomeDecor>>(await client.GetStringAsync(HomeDecorURL)).ToList();
                            var productobj2 = HomeDecorsList.FirstOrDefault(a => a.HName.Equals(item.productName));
                                productobj2.Quantity = productobj2.Quantity - item.Quantity;
                            // _context.HomeDecor.Update(productobj2);
                            await client.PutAsJsonAsync<HomeDecor>(HomeDecorURL + productobj2.HId, productobj2);

                        }

                        }
                        paymentobj.Balance = paymentobj.Balance - ViewBag.Amount2;
                    // _context.Payment.Update(paymentobj);
                        await client.PutAsJsonAsync<Payment>(PaymentURL + paymentobj.PId, paymentobj);
                        var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL));
                        
                        var orderobj = new Order();
                        orderobj.Price = ViewBag.Amount1;
                        orderobj.AddrId = AddressList.FirstOrDefault(a=>a.AddressId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId")))).AddressId;
                        orderobj.DateOfOrder = DateTime.Now;
                        orderobj.PaymentMode = paymentmode.creditCard;
                        orderobj.OrderStatus = OrderStatus.Progress;
                        orderobj.DateOfDelivery = DateTime.Now.AddDays(1);
                    // _context.Order.Add(orderobj);
                    //_context.SaveChanges();
                    await client.PostAsJsonAsync<Order>(OrderURL, orderobj);
                    TempData["PSucess"] = "Payment Was Successfull and Order is Placed";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.InsufficientAmount = "Insufficient amount";
                        ModelState.AddModelError("", "Insufficient amount");
                    }


                }
                else
                {
                    ViewBag.InvalidCredentials = "Invalid Credentials";
                    ModelState.AddModelError("", "Invalid Credentials");

                }
           
           
            return View(payment);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var order = await _context.Order
            // .Include(o => o.Address)
            // .FirstOrDefaultAsync(m => m.OrderId == id);
            var order = JsonConvert.DeserializeObject<Order>(await client.GetStringAsync(OrderURL + id));
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public async Task<IActionResult> Create()
        {
            var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL));
            ViewData["AddrId"] = new SelectList(AddressList, "AddressId", "AddressLineone");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,Price,AddrId,DateOfOrder,PaymentMode,OrderStatus,DateOfDelivery")] Order order)
        {
            if (ModelState.IsValid)
            {
                // _context.Add(order);
                // await _context.SaveChangesAsync();
                await client.PostAsJsonAsync<Order>(OrderURL, order);
                return RedirectToAction(nameof(Index));
            }
            var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL));
            ViewData["AddrId"] = new SelectList(AddressList, "AddressId", "AddressLineone", order.AddrId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var order = await _context.Order.FindAsync(id);
            var order = JsonConvert.DeserializeObject<Order>(await client.GetStringAsync(OrderURL + id));
            if (order == null)
            {
                return NotFound();
            }
            var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL));
            ViewData["AddrId"] = new SelectList(AddressList, "AddressId", "AddressLineone", order.AddrId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,Price,AddrId,DateOfOrder,PaymentMode,OrderStatus,DateOfDelivery")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // _context.Update(order);
                    // await _context.SaveChangesAsync();
                    await client.PutAsJsonAsync<Order>(OrderURL + id, order);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var orders = JsonConvert.DeserializeObject<Order>(await client.GetStringAsync(OrderURL + id));
                    if (!(orders.OrderId== order.OrderId))
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
            var AddressList = JsonConvert.DeserializeObject<List<Address>>(await client.GetStringAsync(AddressURL));
            ViewData["AddrId"] = new SelectList(AddressList, "AddressId", "AddressLineone", order.AddrId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var order = await _context.Order
            //.Include(o => o.Address)
            //.FirstOrDefaultAsync(m => m.OrderId == id);
            var order = JsonConvert.DeserializeObject<Order>(await client.GetStringAsync(OrderURL + id));
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // var order = await _context.Order.FindAsync(id);
            // _context.Order.Remove(order);
            // await _context.SaveChangesAsync();
            await client.DeleteAsync(OrderURL + id);
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderId == id);
        }
    }
}
