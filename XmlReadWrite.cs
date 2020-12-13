using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Lab_12
{
    class XmlReadWrite: IReadWrite
    {
        public void Write(string fileName, List<Phone> phones)
        {
            XmlDocument file = new XmlDocument();
            XmlNode Node = file.CreateElement("phones");
            file.AppendChild(Node);
            foreach (Phone phone in phones)
            {
                XmlElement phoneNode = file.CreateElement("phone");
                phoneNode.SetAttribute("Model", phone.Model);
                phoneNode.SetAttribute("Description", phone.Description);
                phoneNode.SetAttribute("Key", phone.Key);
                Node.AppendChild(phoneNode);
            }
            file.Save(fileName);
        }

        public List<Phone> Read(string fileName)
        {
            XmlDocument file = new XmlDocument();
            file.Load(fileName);
            XmlNode Nodes = file.DocumentElement;
            List<Phone> phones = new List<Phone>();
            foreach (XmlNode Node in Nodes.ChildNodes)
            {
                phones.Add(new Phone(Node.Attributes["Model"].Value,Node.Attributes["Description"].Value,Node.Attributes["Key"].Value));
            }
            return phones;
        }

    }
}
