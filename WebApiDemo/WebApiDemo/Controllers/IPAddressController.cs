using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class IPAddressController : ApiController
    {
        private List<Address> l_address = new List<Address>
        {
            new Address() { IPAddress = "1.91.38.31", Province = "Paris", City = "Paris" }
        };

        public IEnumerable<Address> GetAddresses()
        {
            return l_address;
        }

        public Address GetAddressByIP(String IP)
        {
            return l_address.FirstOrDefault(x => x.IPAddress == IP);
        }
    }
}
