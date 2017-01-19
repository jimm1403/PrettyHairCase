using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLayer
{
    
    public class KeyGenerator1 : IKeyGenerator
    {
        private static volatile KeyGenerator1 instance;
        private static object synchronizationRoot = new Object();
        string random;

        public static KeyGenerator1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new KeyGenerator1();
                        }
                    }
                }
                return instance;
            }
        }

        public string NextKey
        {
            get
            {
                return random = Guid.NewGuid().ToString().Substring(1, 3);
            }
        } 
    }
    public class KeyGenerator2 : IKeyGenerator
    {
        private static volatile KeyGenerator2 instance;
        private static object synchronizationRoot = new Object();

        public static KeyGenerator2 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new KeyGenerator2();
                        }
                    }
                }
                return instance;
            }
        }

        public string NextKey
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
    public class KeyGenerator3 : IKeyGenerator
    {
        private static volatile KeyGenerator3 instance;
        private static object synchronizationRoot = new Object();

        public static KeyGenerator3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new KeyGenerator3();
                        }
                    }
                }
                return instance;
            }
        }

        public string NextKey
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
