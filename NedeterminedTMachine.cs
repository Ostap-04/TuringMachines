using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public class NedeterminedTMachine
    {
        public int State { get; set; }
        public List<Head> Heads { get; }
        public List<NedeterminedTransition> TransitionTable { get; }

        public NedeterminedTMachine(int state, List<Head> heads, List<NedeterminedTransition> transitionTable)
        {
            State = state;
            Heads = heads;
            TransitionTable = transitionTable;
        }

        public void Step()
        {
            foreach (NedeterminedTransition transition in TransitionTable)
            {
                if (transition.InitialState == State &&
                    transition.Read[0] == Heads[0].Read() &&
                    transition.Read[1] == Heads[1].Read() &&
                    transition.Read[2] == Heads[2].Read())
                {
                    if (transition.NextState.Length > 1)
                    {
                        Heads[0].Write(transition.Write[0]);
                        Heads[0].Move(transition.HeadDirection[0]);
                        Heads[1].Write(transition.Write[1]);
                        Heads[1].Move(transition.HeadDirection[1]);
                        Heads[2].Write(transition.Write[2]);
                        Heads[2].Move(transition.HeadDirection[2]);
                        NedeterminedTMachine ntm1 = new NedeterminedTMachine(transition.NextState[0], new List<Head> { Heads[0], Heads[1], Heads[2] }, TransitionTable);
                        //ntm1.Run();

                        NedeterminedTMachine ntm2 = new NedeterminedTMachine(transition.NextState[1], new List<Head> { Heads[0], Heads[1], Heads[2] }, TransitionTable);
                        //ntm2.Run();
                        List<NedeterminedTMachine> m = new List<NedeterminedTMachine> { ntm1, ntm2};
                        var tasks = new Task[2];
                        for (int i = 0; i < 2; i++)
                        {
                            tasks[i] = Task.Run(m[i].Run);
                        }
                    }
                    else 
                    {
                        State = transition.NextState[0];
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

        public NedeterminedTMachine Run()
        {
            NedeterminedTMachine m = this;
            int stepCounter = 1;
            //while (stepCounter != 100)
            while (true)
            {
                if (m.State == -1)
                {
                    ShutDown();
                }
                Console.WriteLine("Step {0}: Tape 1: {1}   Tape 2: {2}    Tape 3: {3}; State = {4}", stepCounter, m.Heads[0], m.Heads[1], m.Heads[2], State);
                m.Step();
                ++stepCounter;
            }
            return m;
        }

        public void ShutDown()
        {
            Console.WriteLine("Accepted");
            Environment.Exit(0);
        }
    }
}
