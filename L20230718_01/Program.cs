using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230718_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State[] states = new State[4];
            Transition[] transitions = new Transition[5];

            states[0] = new State();
            states[0].ID = 1;
            states[0].stateName = "배회";
            states[1] = new State();
            states[1].ID = 2;
            states[1].stateName = "추격";
            states[2] = new State();
            states[2].ID = 3;
            states[2].stateName = "공격";
            states[3] = new State();
            states[3].ID = 4;
            states[3].stateName = "죽음";

            transitions[0] = new Transition();
            transitions[0].currentState = 1;
            transitions[0].condition = "적발견";
            transitions[0].nextState = 2;
            transitions[1] = new Transition();
            transitions[1].currentState = 2;
            transitions[1].condition = "적놓침";
            transitions[1].nextState = 1;
            transitions[2] = new Transition();
            transitions[2].currentState = 2;
            transitions[2].condition = "사정거리접근";
            transitions[2].nextState = 3;
            transitions[3] = new Transition();
            transitions[3].currentState = 3;
            transitions[3].condition = "사정거리이탈";
            transitions[3].nextState = 2;
            transitions[4] = new Transition();
            transitions[4].currentState = 3;
            transitions[4].condition = "HP없음";
            transitions[4].nextState = 4;

            int monsterCurrentState = 2;
            string monsterCondition = "적놓침";
            int monsterNextState = 0;

            monsterNextState = transitions[0].Trans(transitions, monsterCurrentState, monsterCondition);

            for (int i = 0; i < states.Length; i++)
            {
                if (states[i].ID == monsterNextState)
                {
                    Console.WriteLine(states[i].stateName);
                }
            }
        }
    }
}
