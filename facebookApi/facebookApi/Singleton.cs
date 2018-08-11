using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facebookApi
{
    public class Singleton<T> where T : class
    {
        private static volatile T m_Instance = null;
        private static volatile object instanceLock = new object();

        private Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (instanceLock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = (T)Activator.CreateInstance(typeof(T));
                        }
                    }
                }

                return m_Instance;
            }
        }
    }
}
