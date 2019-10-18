using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5andSalting
{
    public class EncryptDecrypt
    {
        //This method encrypts the text using MD5
        public static string GetMd5Hash(MD5 md5Hash, string text)
        {
            byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sBuilder = new StringBuilder();
            foreach(byte b in bytes)
            {
                sBuilder.Append(b.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        //This method encrypts the text using MD5 and Salt
        public static SecureData GetMd5HashWithSalt(MD5 md5Hash, string text)
        {
            SecureData secureData = new SecureData();
            secureData.Salt = GetSalt();
            string new_text = String.Concat(text, secureData.Salt);
            byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(new_text));
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                sBuilder.Append(b.ToString("x2"));
            }
            secureData.MD5Hash = sBuilder.ToString();
            return secureData;
        }

        //This method encrypts the text using MD5 and Salt and Pepper
        public static SecureData GetMd5HashWithSaltAndPepper(MD5 md5Hash, string text, string pepper)
        {
            SecureData secureData = new SecureData();
            secureData.Salt = GetSalt();
            string new_text = String.Concat(text, secureData.Salt, pepper);
            byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(new_text));
            StringBuilder sBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                sBuilder.Append(b.ToString("x2"));
            }
            secureData.MD5Hash = sBuilder.ToString();
            return secureData;
        }

        //This method compares the text using MD5
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (comparer.Compare(hashOfInput, hash)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method compares the text using MD5 and Salt
        public static bool VerifyMd5HashWithSalt(MD5 md5Hash, string input, string hash, string salt)
        {
            string new_input = String.Concat(input, salt);
            string hashOfInput = GetMd5Hash(md5Hash, new_input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (comparer.Compare(hashOfInput, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method compares the text using MD5 and Salt and Pepper
        public static bool VerifyMd5HashWithSaltAndPepper(MD5 md5Hash, string input, string hash, string salt, string pepper)
        {
            string new_input = String.Concat(input, salt, pepper);
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (comparer.Compare(hashOfInput, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Generate random salt
        private static string GetSalt()
        {
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
            // Maximum length of salt
            int max_length = 32;
            // Empty salt array
            byte[] salt = new byte[max_length];
            // Build the random bytes
            random.GetNonZeroBytes(salt);
            // Return the string encoded salt
            return Convert.ToBase64String(salt);
        }
    }
}
