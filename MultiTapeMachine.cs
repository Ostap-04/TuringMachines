using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public class MultiTapeMachine
    {
        public int State { get; set; }
        public List<Head> Heads { get; }
        public List<UniversalTransition> TransitionTable { get; }

        public MultiTapeMachine(int state, List<Head> heads, List<UniversalTransition> transitionTable)
        {
            State = state;
            Heads = heads;
            TransitionTable = transitionTable;
        }

        public void Step()
        {
            if (Heads.Count == 1)
            {
                foreach (UniversalTransition transition in TransitionTable)
                {
                    if (transition.InitialState == State && 
                        transition.Read[0] == Heads[0].Read())
                    {
                        State = transition.NextState;
                        Heads[0].Write(transition.Write[0]);
                        Heads[0].Move(transition.HeadDirection[0]);
                        break;
                    }
                }
            }
            else if (Heads.Count == 2)
            {
                foreach (UniversalTransition transition in TransitionTable)
                {
                    if (transition.InitialState == State && 
                        transition.Read[0] == Heads[0].Read() && 
                        transition.Read[1] == Heads[1].Read())
                    {
                        State = transition.NextState;
                        Heads[0].Write(transition.Write[0]);
                        Heads[0].Move(transition.HeadDirection[0]);
                        Heads[1].Write(transition.Write[1]);
                        Heads[1].Move(transition.HeadDirection[1]);
                        break;
                    }
                }
            }
            else if (Heads.Count == 3)
            {
                foreach (UniversalTransition transition in TransitionTable)
                {
                    if (transition.InitialState == State && 
                        transition.Read[0] == Heads[0].Read() && 
                        transition.Read[1] == Heads[1].Read() && 
                        transition.Read[2] == Heads[2].Read())
                    {
                        State = transition.NextState;
                        Heads[0].Write(transition.Write[0]);
                        Heads[0].Move(transition.HeadDirection[0]);
                        Heads[1].Write(transition.Write[1]);
                        Heads[1].Move(transition.HeadDirection[1]);
                        Heads[2].Write(transition.Write[2]);
                        Heads[2].Move(transition.HeadDirection[2]);
                        break;
                    }
                }
            }

        }

        public MultiTapeMachine Run()
        {
            MultiTapeMachine m = this;
            int stepCounter = 1;
            //while (stepCounter != 100)
            while (m.State >= 0)
            {
                if (Heads.Count == 1)
                    Console.WriteLine("Step {0}: {1}", stepCounter, m.Heads[0]);
                else if (Heads.Count == 2)
                    Console.WriteLine("Step {0}: Tape 1 = {1}   Tape 2 = {2}; State = {3}", stepCounter, m.Heads[0], m.Heads[1], State);
                else if (Heads.Count == 3)
                    Console.WriteLine("Step {0}: Tape 1: {1}   Tape 2: {2}    Tape 3: {3}; State = {4}", stepCounter, m.Heads[0], m.Heads[1], m.Heads[2], State);
                m.Step();
                ++stepCounter;
            }
            return m;
        }
    }
}
