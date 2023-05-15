using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public class Machine
    {
        public int State { get; set; }
        public Head Head { get; }
        public List<Transition> TransitionTable { get; }

        public Machine(int state, Head head, List<Transition> transitionTable)
        {
            State = state;
            Head = head;
            TransitionTable = transitionTable;
        }

        public void Step()
        {
            foreach (Transition transition in TransitionTable)
            {
                if (transition.InitialState == State && transition.Read == Head.Read())
                {
                    State = transition.NextState;
                    Head.Write(transition.Write);
                    Head.Move(transition.HeadDirection);
                    break;
                }
            }
        }
        public Machine Run()
        {
            Machine m = this;
            int stepCounter = 1;
            while (m.State >= 0)
            {
                Console.WriteLine("Step {0}: {1}; State = {2}", stepCounter, m.Head, State);
                m.Step();
                ++stepCounter;
            }
            return m;
        }
    }
}
