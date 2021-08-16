using DNTCaptcha.Core;
using e_commerce.Context;
using e_commerce.Models;
using e_commerce.Models.Repository;
using e_commerce.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class LoginController : Controller
    {
        private readonly ShoppingDbContext _context;

        HttpClient client = new HttpClient();
        string AdminURL = "https://localhost:44366/api/Admins/";
        string CustomerURL = "https://localhost:44366/api/Customers/";
        string ElectronicURL = "https://localhost:44366/api/ElectronicDevices/";
        string FashionURL = "https://localhost:44366/api/Fashions/";
        string HomeDecorURL = "https://localhost:44366/api/HomeDecors/";
        string OrderReviewURL = "https://localhost:44366/api/OrderReviews/";

        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private string generatedToken = null;


        public LoginController(ShoppingDbContext context, IConfiguration configuration, IUserRepository userRepository, ITokenService tokenService)
        {
            _config = configuration;
            _context = context;
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
       
        public IActionResult Index(int id)
        {
            if (id == 1)
                return RedirectToAction("Admin");
            else
                return RedirectToAction("CustomerRegistration");
        }       

        public IActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Admin(Admin obj)
        {
            var adminList = JsonConvert.DeserializeObject<List<Admin>>(await client.GetStringAsync(AdminURL)).ToList();
            var obj1 = adminList.FirstOrDefault(a => a.UserName.Equals(obj.UserName) && a.Password.Equals(obj.Password));

             //var obj1 = _context.Admin.Where(a => a.UserName.Equals(obj.UserName) && a.Password.Equals(obj.Password)).FirstOrDefault();
          
            //var obj1 = JsonConvert.DeserializeObject<Admin>(await client.GetStringAsync(url + obj.UserId));
            if (obj1 != null)
            {
                HttpContext.Session.SetString("userid", obj1.UserId.ToString());
                HttpContext.Session.SetString("username", obj1.UserName.ToString());
                TempData["AMessage"] = "Successfully Login";
                return this.RedirectToAction("AdminView");
            }
            else
            {
                ViewBag.AMessage = "Login Failed. Wrong Username or Password !!!";
                ModelState.AddModelError("", "UserName or Password is wrong");
            }
            return View();
        }
        public ActionResult AdminLogOff()
        {
            HttpContext.Session.Clear();
            TempData["ALogOff"] = "Log Off done Successfully";
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AMyAccount()
        {
            ViewBag.AdminAccountList = JsonConvert.DeserializeObject<List<Admin>>(await client.GetStringAsync(AdminURL)).ToList().Where(a => a.UserId.Equals(Convert.ToInt32(HttpContext.Session.GetString("userid"))));
            return View();
        }
        public async Task<IActionResult> CMyAccount()
        {
            ViewBag.Account1 = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList().Where(a => a.UserId.Equals(Convert.ToInt32(HttpContext.Session.GetString("custId"))));
            return View();
        }
        public async Task<IActionResult> AdminView()
        {
            ViewBag.ReviewList = JsonConvert.DeserializeObject<List<OrderReview>>(await client.GetStringAsync(OrderReviewURL)).ToList();
            ViewBag.EleList = JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicURL)).ToList();
            ViewBag.HomeList = JsonConvert.DeserializeObject<List<HomeDecor>>(await client.GetStringAsync(HomeDecorURL)).ToList();
            ViewBag.FashionList = JsonConvert.DeserializeObject<List<Fashion>>(await client.GetStringAsync(FashionURL)).ToList();
            return View();
        }       
        public ActionResult CustomerRegistration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CustomerRegistration(Customer obj)
        {
            if (ModelState.IsValid)
            {
                // _context.Customer.Add(obj)
                // _context.SaveChanges();
                await client.PostAsJsonAsync<Customer>(CustomerURL, obj);
                ModelState.Clear();
                ViewBag.Message = obj.FirstName + " " + obj.LastName + "Successfully Registered.";
            }
            return RedirectToAction("Customer");
        }

        public ActionResult Customer()
        {
            if (HttpContext.Session.GetString("username1") != null && HttpContext.Session.GetString("password") != null)
            {
                return RedirectToAction("CustomerView");
            }
            return View();
        }
        [AllowAnonymous]
        //[Route("login")]
        [HttpPost, ActionName("Customer")]
        public async Task<IActionResult> AuthorizeUser(Customer userModel)
        {
            var CustomerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            var obj1 = CustomerList.Where(a => a.UserName.Equals(userModel.UserName)).FirstOrDefault();
            if (obj1.Password == userModel.Password)
            {
                generatedToken = _tokenService.BuildToken(_config["Authentication:AccessTokenKey"].ToString(), _config["Authentication:Issuer"].ToString(), obj1);
                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    HttpContext.Session.SetString("custId", obj1.UserId.ToString());
                    HttpContext.Session.SetString("username1", obj1.UserName.ToString());
                    HttpContext.Session.SetString("password", obj1.Password.ToString());
                    return RedirectToAction("AuthorizationSuccess");
                }
                else
                {
                    ModelState.AddModelError("Error", "Access Denied, Please Enter Proper Username and Password");
                }
            }
            else
            {
                ViewBag.CLogin = "Login Failed. Wrong Username or Password !!!";
                ModelState.AddModelError("Error", "UserName or Password is wrong");
            }
            return View(userModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthorizationSuccess()
        {

            string token = HttpContext.Session.GetString("Token");
            if (token == null)
            {
                return (RedirectToAction("Customer"));
            }
            if (!_tokenService.ValidateToken(_config["Authentication:AccessTokenKey"].ToString(), _config["Authentication:Issuer"].ToString(), token))
            {
                return (RedirectToAction("Customer"));
            }

            ViewBag.token = token;
            return RedirectToAction("CustomerView");
            //  return RedirectToAction("Dashboard", "Users");
        }

       /* [HttpPost]
        public async Task<IActionResult> Customer(Customer obj)
        {
            var CustomerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(CustomerURL)).ToList();
            var obj1 = CustomerList.FirstOrDefault(a => a.UserName.Equals(obj.UserName) && a.Password.Equals(obj.Password));
            // var obj1 = _context.Customer.Where(a => a.UserName.Equals(obj.UserName) && a.Password.Equals(obj.Password)).FirstOrDefault();

            if (obj1 != null)
            {
               
                HttpContext.Session.SetString("custId", obj1.UserId.ToString());
                HttpContext.Session.SetString("username1", obj1.UserName.ToString());
                TempData["CLogin"] = "Successfully Login";
                return RedirectToAction("CustomerView");
            }
            else
            {
                ViewBag.CLogin = "Login Failed. Wrong Username or Password !!!";
                ModelState.AddModelError("Error", "UserName or Password is wrong");
                
            }

            return View();


        }*/

        


        public async Task<IActionResult> CustomerView()
        {

            ViewBag.EleList1 = JsonConvert.DeserializeObject<List<ElectronicDevice>>(await client.GetStringAsync(ElectronicURL)).ToList();
            ViewBag.HomeList1 = JsonConvert.DeserializeObject<List<HomeDecor>>(await client.GetStringAsync(HomeDecorURL)).ToList();
            ViewBag.FashionList1 = JsonConvert.DeserializeObject<List<Fashion>>(await client.GetStringAsync(FashionURL)).ToList();
            return View();
        }
       
    }

}
