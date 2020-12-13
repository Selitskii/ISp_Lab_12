using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_12
{
    class BinaryReadWrite:IReadWrite
    {

        public void Write(string fileName, List<Phone> phones)
        {
            BinaryWriter file = new BinaryWriter(File.OpenWrite(fileName));
            foreach (Phone phone in phones)
            {
                file.Write(phone.Model);
                file.Write(phone.Description);
                file.Write(phone.Key);
            }
            file.Flush();
            file.Close();
        }
        public List<Phone> Read(string fileName)
        {
            BinaryReader file = new BinaryReader(File.OpenRead(fileName));
            List<Phone> phones= new List<Phone>();
            while (file.BaseStream.Position != file.BaseStream.Length)
            {
                phones.Add(new Phone(file.ReadString(), file.ReadString(), file.ReadString()));
            }
            file.Close();
            return phones;
        }

    }
}
