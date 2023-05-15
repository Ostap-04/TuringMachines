using System.Threading.Channels;

namespace TuringMachines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneTapeTuringMachine();
            //MultiTapeTuringMachine();
            NedeteminedTuringMachine();
        }

        static void OneTapeTuringMachine()
        {
            Machine m = new Machine(
                0, new Head(new List<char>("111+11"), 0),
                TransitionTables.UnaryAddition());
            m.Run();
            Console.WriteLine("Result: {0}", m.Head);
            Console.ReadLine();

            m = new Machine(
                0, new Head(new List<char>("1001+111"), 0),
                TransitionTables.BinaryAddition());
            m.Run();
            Console.WriteLine("Result: {0}", m.Head);
            Console.ReadLine();

            m = new Machine(
                0, new Head(new List<char>("111111-111"), 0),
                TransitionTables.UnarySubstraction());
            m.Run();
            Console.WriteLine("Result: {0}", m.Head);
            Console.ReadLine();

            m = new Machine(
                0, new Head(new List<char>("111_11"), 0),
                TransitionTables.UnaryMultiplication());
            m.Run();
            Console.WriteLine("Result: {0}", m.Head);
            Console.ReadLine();

            m = new Machine(
                0, new Head(new List<char>("1111111111111111111111111111111111111111111111111111111111111111$"), 0),
                TransitionTables.Translation());
            m.Run();
            Console.WriteLine("Result: {0}", m.Head);
            Console.ReadLine();
        }

        static void MultiTapeTuringMachine()
        {
            MultiTapeMachine mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("01110"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.Polindrom());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[1]);
            Console.ReadLine();

            mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("0010"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.Polindrom());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[1]);
            Console.ReadLine();

            mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("0101010"), 0), new Head(new List<char>("_1110011"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.BinaryAddition());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[2]);
            Console.ReadLine();

            mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("111"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.ToPower());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[1]);
            Console.ReadLine();

            mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("9"), 0), new Head(new List<char>("_4"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.DecimalSubstraction());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[2]);
            Console.ReadLine();

            mtm = new MultiTapeMachine(
                0, new List<Head> { new Head(new List<char>("11110"), 0), new Head(new List<char>("1111"), 0), new Head(new List<char>("_"), 0) },
                MultiTransitionTables.BinaryDivision());
            mtm.Run();
            Console.WriteLine("Result: {0}", mtm.Heads[2]);
            Console.ReadLine();
        }

        static void NedeteminedTuringMachine()
        {
            NedeterminedTMachine ntm = new NedeterminedTMachine(
                0, new List<Head> { new Head(new List<char>("100101000"), 0), new Head(new List<char>("b"), 0), new Head(new List<char>("b"), 0) },
                NedeterminedTransitionsTable.MyTask());
            ntm.Run();
        }
    }
}