using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class PhoneFactory
    {
        public IReadWrite ReadWrite(string fileName)
        {
            string[] nameType = fileName.Split('.');

            string fileType = nameType[nameType.Length - 1];
            switch (fileType.ToLower())
            {
                case "bin": return new BinaryReadWrite();
                case "txt": return new TextReadWrite();
                case "xml": return new XmlReadWrite();
                default: throw new Exception("Unsupported file type");
            }
        }
    }
}
