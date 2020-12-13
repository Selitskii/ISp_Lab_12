using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class Phone
    {
        private string key="";
        private string model="";
        private string description="";

        public Phone()
        {
        }

        public Phone(string model, string description, string key) { 
            Model = model;
            Description = description;
            Key = key;
        }

        public string Model { get => model; set => model = value; }
        public string Description { get => description; set => description = value; }
        public string Key { get => key; set => key = value; }

        public override bool Equals(object obj)
        {
            return obj is Phone phone &&
                   Model == phone.Model &&
                   Description == phone.Description &&
                   Key == phone.Key;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Description, Key);
        }

        public override string ToString()
        {
            return "Phone: Key =" + Key + "; Mode =" + Model + "; Description =" + Description + ";";
        }
    }
}
