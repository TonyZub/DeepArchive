using System;

namespace DeepArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            ByteConverter byteConverter = new ByteConverter();
            byteConverter.PrintBytes(byteConverter.GetBytes("Hello World!"));
        }
    }
}
