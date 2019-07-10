using FundAChild.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAChild.WebUI.Models.QuoteRequests
{
    public class QuoteRequestListViewModel
    {
        public IEnumerable<QuoteRequest> QuoteRequests { get; set; }
    }
}