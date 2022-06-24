using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Context
{
    public class ApiURLS
    {
        static string AdminURL = "https://localhost:44366/api/Admins/";

        static string CustomerURL = "https://localhost:44366/api/Customers/";
        static string AddressURL = "https://localhost:44366/api/Addresses/";
        static string CartURL = "https://localhost:44366/api/Carts/";

        static string ElectronicURL = "https://localhost:44366/api/ElectronicDevices/";
        static string FashionURL = "https://localhost:44366/api/Fashions/";
        static string HomeDecorURL = "https://localhost:44366/api/HomeDecors/";

        static string OrderURL = "https://localhost:44366/api/Orders/";
        static string PaymentURL = "https://localhost:44366/api/Payments/";
        static string OrderReviewURL = "https://localhost:44366/api/OrderReviews/";

        public static string GetAdminUrl() { return AdminURL; }
        public static string GetCustomerUrl() { return CustomerURL; }

        public static string GetAddressUrl() { return AddressURL; }
        public static string GetCartUrl() { return CartURL; }
        public static string GetElectronicDevicesUrl() { return ElectronicURL; }
        public static string GetFashionUrl() { return FashionURL; }
        public static string GetHomeDecorUrl() { return HomeDecorURL; }
        public static string GetOrderUrl() { return OrderURL; }
        public static string GetPaymentUrl() { return PaymentURL; }
        public static string GetOrderReviewUrl() { return OrderReviewURL; }

    }
}
