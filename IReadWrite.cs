using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    interface IReadWrite
    {
        public List<Phone> Read(string fileName);
        public void Write(string fileName, List<Phone> phones);
    }
}
