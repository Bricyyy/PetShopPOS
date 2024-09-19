using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MilkTeaOrderAndInventorySystem
{

    public class PassEnCDeC
    {
        private readonly TripleDESCryptoServiceProvider _des = new TripleDESCryptoServiceProvider();
        private readonly UnicodeEncoding _uni = new UnicodeEncoding();
        private readonly byte[] _key;
        private readonly byte[] _iv;

        public PassEnCDeC(byte[] key, byte[] iv)
        {
            _key = key;
            _iv = iv;
        }

        public byte[] Encrypt(byte[] input)
        {
            return CryptoTransform(input, _des.CreateEncryptor(_key, _iv));
        }

        public string Encrypt(string text)
        {
            byte[] input = _uni.GetBytes(text);
            byte[] output = CryptoTransform(input, _des.CreateEncryptor(_key, _iv));
            return Convert.ToBase64String(output);
        }

        public byte[] Decrypt(byte[] input)
        {
            return CryptoTransform(input, _des.CreateDecryptor(_key, _iv));
        }

        public string Decrypt(string text)
        {
            byte[] input = Convert.FromBase64String(text);
            byte[] output = CryptoTransform(input, _des.CreateDecryptor(_key, _iv));
            return _uni.GetString(output);
        }

        private byte[] CryptoTransform(byte[] input, ICryptoTransform transform)
        {
            byte[] result;

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                    ms.Position = 0L;
                    result = ms.ToArray();
                }
            }

            return result;
        }
    }
}