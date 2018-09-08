using System;
using System.Collections.Generic;

namespace facebookApi
{
    public class RunType
    {
        private static ISet<Action<eRunType>> m_RunTypeChangedActions = new HashSet<Action<eRunType>>();

        public enum eRunType
        {
            Debug,
            Release
        }

        private RunType()
        {
        }

        public void SubscribeToRunTypeChanged(Action<eRunType> i_Action)
        {
            if (!m_RunTypeChangedActions.Contains(i_Action))
            {
                m_RunTypeChangedActions.Add(i_Action);
            }
        }

        public void RunTypeChanged(eRunType i_RunType)
        {
            foreach (Action<eRunType> action in m_RunTypeChangedActions)
            {
                action.Invoke(i_RunType);
            }
        }
    }
}
