using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public static class MessagesBox
    {
        public static string showMessages(string text)
        {
            return "<script>alert('" + text + "')</script>";
        }
    }
}