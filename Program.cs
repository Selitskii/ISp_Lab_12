using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>() {
                 Create("Redmi 4", "Xiaomi"),
                Create("S20", "Samsung"),
                Create("Pixel 4", "Google"),
                Create("Mi A1", "Xiaomi"),
                Create("iPhone 12 Mini", "Apple")
            };


            Console.WriteLine("Checking:");
            Test(phones, "TextFile.txt");
            Console.WriteLine("TEXT check success");
            Test(phones, "BinFile.bin");;
            Console.WriteLine("BIN check success");
            Test(phones, "XMLFile.xml");
            Console.WriteLine("XML check success");

            Console.ReadLine();
        }

        private static Phone Create(string model, string description)
        {
            return new Phone(model, description, KeyGenerator.Source.Generate());
        }


        private static void Test(List<Phone> phones, string fileName)
        {
            IReadWrite readwrite = new PhoneFactory().ReadWrite(fileName);
            readwrite.Write(fileName, phones);
            List<Phone> newPhones = readwrite.Read(fileName);
            if (phones.Count != newPhones.Count)
            {
                Console.WriteLine("Erroy size");
                return;
            }
            for (int i = 0; i < phones.Count; i++)
            {
                if (!phones[i].Equals(newPhones[i]))
                {
                    Console.WriteLine("Phone is different");
                }
            }
        }

    }
}
