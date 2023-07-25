using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230718_01
{
    class Transition
    {
        public int currentState;
        public string condition;
        public int nextState;

        public int Trans(Transition[] transitions, int currentState, string condition)
        {
            for (int i = 0; i < transitions.Length; i++)
            {
                if ((currentState == transitions[i].currentState) && (condition == transitions[i].condition))
                {
                    return transitions[i].nextState;
                }
            }
            return 0;
        }
    }
}
