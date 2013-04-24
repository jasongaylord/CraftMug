using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CraftMug.Core.Utilities
{
    public static class StreamToXDocument
    {
        public static XDocument GetXDocument(Stream stream)
        {
            // read the file to find errors
            string documentText = ReadBytes(stream);

            return XDocument.Parse(documentText);
        }

        private static string ReadBytes(Stream stream)
        {
            byte[] buffer = new byte[stream.Length];

            stream.Read(buffer, 0, buffer.Length);

            string normal = string.Empty;
            string hex = BitConverter.ToString(buffer).Replace("-", "");

            while (hex.Length > 0)
            {
                // Use ToChar() to convert each ASCII value (two hex digits) to the actual character
                normal += System.Convert.ToChar(System.Convert.ToUInt32(hex.Substring(0, 2), 16)).ToString();
                // Remove from the hex object the converted value
                hex = hex.Substring(2, hex.Length - 2);
            }

            return normal;
        }
    }
}