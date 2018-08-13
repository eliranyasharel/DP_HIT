using System;
using System.Reflection;

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
                            m_Instance = (T)typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null).Invoke(null);
                        }
                    }
                }

                return m_Instance;
            }
        }
    }
}
