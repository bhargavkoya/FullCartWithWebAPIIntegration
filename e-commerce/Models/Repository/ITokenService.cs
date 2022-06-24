using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models.Repository
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, Customer user);
        bool ValidateToken(string key, string issuer, string token);
    }
}
