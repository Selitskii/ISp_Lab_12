using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class KeyGenerator
    {
        private KeyGenerator()
        { }
        
        private static KeyGenerator source = null;

        public static KeyGenerator Source
        {
            get
            {
                if (source == null)
                    source = new KeyGenerator();

                return source;
            }
        }

        public String Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
