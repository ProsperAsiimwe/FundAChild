using FundAChild.Domain.Entities;
using FundAChild.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAChild.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}