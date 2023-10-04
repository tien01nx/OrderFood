using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entities
{
    public class TokenManager
    {
        public static SecureString ConvertToSecureString(string plainText)
        {
            SecureString secureString = new SecureString();
            foreach (char c in plainText)
            {
                secureString.AppendChar(c);
            }
            secureString.MakeReadOnly();
            return secureString;
        }

        public static string ConvertToPlainText(SecureString secureString)
        {
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(secureString);
            try
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
        }

        // Lưu trữ JWT trong SecureString
        public static SecureString StoreToken(string token)
        {
            return ConvertToSecureString(token);
        }

        // Lấy JWT từ SecureString
        public static string RetrieveToken(SecureString secureString)
        {
            return ConvertToPlainText(secureString);
        }
    }
}
