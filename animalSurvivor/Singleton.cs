using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal class Singleton<T> where T : Singleton<T>, new()
    {
        private static T? _instance = null;
        private static readonly object padlock = new();

        public static T? Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(padlock)
                    {
                        _instance = new T();
                    }
                }
                return _instance;
            }
        }
    }
}
