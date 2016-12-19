using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public static class GenerateRandomCode
    {
        public static string RandomCode()
        {
            string s = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                s += random.Next(10).ToString();
            }
            return s;
        }
    }
}