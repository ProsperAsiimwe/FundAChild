using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagicApps.Infrastructure.Helpers;

namespace FundAChild.WebUI.Infrastructure.Helpers
{
    public class CookieHelper
    {
        public void SetCookies(int referenceId)
        {
            ReferenceId = referenceId;
            Authorised = true;
        }

        public bool Authorised {
            get {
                bool _id = bool.Parse(CustomHelper.GetCookieValue("FundAChild-Authorised", Boolean.FalseString));
                return _id;
            }
            set {
                CustomHelper.CreateCookie("FundAChild-Authorised", value.ToString());
            }
        }

        public int ReferenceId {
            get {
                int _id = int.Parse(CustomHelper.GetCookieValue("FundAChild-ReferenceId"));
                return _id;
            }
            set {
                CustomHelper.CreateCookie("FundAChild-ReferenceId", value.ToString());
            }
        }

        public void Flush()
        {
            CustomHelper.CreateCookie("FundAChild-Authorised", Boolean.FalseString, -1);
            CustomHelper.CreateCookie("FundAChild-ReferenceId", "0", -1);
        }
    }
}