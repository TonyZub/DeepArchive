using System;
using System.Text;


namespace DeepArchive
{
    public sealed class ByteConverter
    {
        #region Methods

        public byte[] GetBytes(string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }

        public void PrintBytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.WriteLine(bytes[i]);
            }
        }

        #endregion
    }
}
