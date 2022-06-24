using E_CommerceAPI.Context;
using E_CommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace E_CommerceAPI.Data
{
    public class Seed
    {
        public static async Task SeedElectronic(ShoppingDbContext shoppingDbContext)
        {
            if (shoppingDbContext.ElectronicDevice.Any()) return;

            var eledata= await System.IO.File.ReadAllTextAsync("Data/ElectronicDevices.json");
           

            var electronics = JsonSerializer.Deserialize<List<ElectronicDevice>>(eledata);


            foreach(var item in electronics)
            {
                item.Category = (Category)item.Category;
                item.EBrand = (EBrand)item.EBrand;

                shoppingDbContext.ElectronicDevice.Add(item);
            }

            await shoppingDbContext.SaveChangesAsync();
            
            
        }
        public static async Task SeedFashion(ShoppingDbContext shoppingDbContext)
        {
            if (shoppingDbContext.Fashion.Any()) return;

            var fasdata = await System.IO.File.ReadAllTextAsync("Data/Fashion.json");


            var fashion = JsonSerializer.Deserialize<List<Fashion>>(fasdata);

            foreach (var fash in fashion)
            {
                shoppingDbContext.Fashion.Add(fash);
            }

            await shoppingDbContext.SaveChangesAsync();

        }
        public static async Task SeedHoomeDecor(ShoppingDbContext shoppingDbContext)
        {
             if (shoppingDbContext.HomeDecor.Any()) return;

            var homedecdata = await System.IO.File.ReadAllTextAsync("Data/HomeDecor.json");


            var homedecor = JsonSerializer.Deserialize<List<HomeDecor>>(homedecdata);

            foreach (var homed in homedecor)
            {
                shoppingDbContext.HomeDecor.Add(homed);
            }

            await shoppingDbContext.SaveChangesAsync();



        }
        public static async Task SeedAdmin(ShoppingDbContext shoppingDbContext)
        {
            if (shoppingDbContext.Admin.Any()) return;

            var admin = new Admin()
            {
                FirstName = "Admin",
                LastName = "Admin",
                Email = "Admin123@gmail.com",
                UserName = "Admin",
                Password = "Admin@123",
                ConfirmPassword = "Admin@123",
                Balance = 100000
            };

            shoppingDbContext.Admin.Add(admin);


            

           

            await shoppingDbContext.SaveChangesAsync();

        }
    }
}
