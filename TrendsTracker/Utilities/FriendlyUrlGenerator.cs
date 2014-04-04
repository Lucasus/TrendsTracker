using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TrendsTracker.Web.Utilities
{
    public class FriendlyUrlGenerator
    {
        public string ToFriendlyUrlName(string s)
        {
            s = s.Replace("#", "sharp");
            s = Regex.Replace(s, @"[^A-Za-z0-9_~]+", "-");
            return s.ToLower();
        }
    }
}