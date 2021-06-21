using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.BL
{
    class EncryptorDecryptorBL
    {
        public string EncryptData(string raw)
        {
            try
            {
                byte[] encData_byte = new byte[raw.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(raw);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
    }
}
