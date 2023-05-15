using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public class Transition
    {
        public int InitialState { get; }
        public char Read { get; }
        public char Write { get; }
        public HeadDirection HeadDirection { get; }
        public int NextState { get; }

        public Transition(int initialState, char toRead, char toWrite, HeadDirection headDirection, int nextState)
        {
            InitialState = initialState;
            Read = toRead;
            Write = toWrite;
            HeadDirection = headDirection;
            NextState = nextState;
        }
    }

    public class UniversalTransition
    {
        public int InitialState { get; }
        public char[] Read { get; }
        public char[] Write { get; }
        public HeadDirection[] HeadDirection { get; }
        public int NextState { get; }

        public UniversalTransition(int initialState, char[] toRead, char[] toWrite, HeadDirection[] headDirection, int nextState)
        {
            InitialState = initialState;
            Read = toRead;
            Write = toWrite;
            HeadDirection = headDirection;
            NextState = nextState;
        }
    }

    public class NedeterminedTransition 
    {
        public int InitialState { get; }
        public char[] Read { get; }
        public char[] Write { get; }
        public HeadDirection[] HeadDirection { get; }
        public int[] NextState { get; }

        public NedeterminedTransition(int initialState, char[] toRead, char[] toWrite, HeadDirection[] headDirection, int[] nextState)
        {
            InitialState = initialState;
            Read = toRead;
            Write = toWrite;
            HeadDirection = headDirection;
            NextState = nextState;
        }
    }

}
