﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace K204ShoppingApp
{
   static class Extensions
    {
        public static bool IsEmptyString(string[] values,string text)
        {
            foreach (var val in values)
            {
                if (val == text)
                {
                    return false;
                }
            }
            return true;
        }
        public static string HashMe(this string pas)
        {
            byte[] myByte = new ASCIIEncoding().GetBytes(pas);
            byte[] hashByte = new SHA256Managed().ComputeHash(myByte);
            string hashString = new ASCIIEncoding().GetString(hashByte);
            return hashString;
        }
    }
}
