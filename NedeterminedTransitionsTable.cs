using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public static class NedeterminedTransitionsTable
    {
        public static List<NedeterminedTransition> MyTask() => new()
        {
            new NedeterminedTransition(0, new char[] {'1', 'b', 'b'}, new char[] {'1', '$', '$'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.Right}, new int[] {1}),
            
            new NedeterminedTransition(1, new char[] {'1', 'b', 'b'}, new char[] {'1', 'b', 'b'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, new int[] {2, 3}),

            new NedeterminedTransition(2, new char[] {'0', 'b', 'b'}, new char[] {'0', '0', 'b'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.Right, HeadDirection.NoMove}, new int[] {2}),
            new NedeterminedTransition(2, new char[] {'1', 'b', 'b'}, new char[] {'1', 'b', 'b'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, new int[] {1}),
            new NedeterminedTransition(2, new char[] {'b', 'b', 'b'}, new char[] {'b', 'b', 'b'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.Left}, new int[] {4}),

            new NedeterminedTransition(3, new char[] {'0', 'b', 'b'}, new char[] {'0', 'b', '0'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.Right}, new int[] {3}),
            new NedeterminedTransition(3, new char[] {'1', 'b', 'b'}, new char[] {'1', 'b', 'b'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, new int[] {1}),
            new NedeterminedTransition(3, new char[] {'b', 'b', 'b'}, new char[] {'b', 'b', 'b'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.Left}, new int[] {4}),

            new NedeterminedTransition(4, new char[] {'b', '0', '0'}, new char[] {'b', '0', '0'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.Left}, new int[] {4}),
            new NedeterminedTransition(4, new char[] {'b', '$', '$'}, new char[] {'b', '$', '$'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, new int[] {-1})
        };
    }
}
