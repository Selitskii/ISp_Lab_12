using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_12
{
    class TextReadWrite:IReadWrite
    {
        public void Write(string fileName, List<Phone> phones)
        {
            StreamWriter fileStream = new StreamWriter(fileName);
            foreach (Phone phone in phones)
            {
                fileStream.WriteLine(phone.Model);
                fileStream.WriteLine(phone.Description);
                fileStream.WriteLine(phone.Key);
            }
            fileStream.Flush();
            fileStream.Close();
        }

        public List<Phone> Read(string fileName)
        {
            string[] file = File.ReadAllLines(fileName);
            List<Phone> result = new List<Phone>();
            for (int i = 0; i < file.Length; i += 3)
            {
                result.Add(new Phone(file[i], file[i + 1], file[i + 2]));
            }
            return result;
        }
    }
}
