using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public static class TransitionTables
    {
        public static List<Transition> UnaryAddition() => new()
        {
            new Transition(0, '_', '_', HeadDirection.Right, 0),
            new Transition(0, '1', '1', HeadDirection.Right, 1),

            new Transition(1, '+', '1', HeadDirection.Right, 2),
            new Transition(1, '1', '1', HeadDirection.Right, 1),

            new Transition(2, '_', '_', HeadDirection.Left, 3),
            new Transition(2, '1', '1', HeadDirection.Right, 2),

            new Transition(3, '1', '_', HeadDirection.NoMove, -1)
        };

        public static List<Transition> BinaryAddition() => new()
        {
            new Transition(0, '1', '1', HeadDirection.Right, 0),
            new Transition(0, '0', '0', HeadDirection.Right, 0),
            new Transition(0, '+', '+', HeadDirection.Right, 0),
            new Transition(0, '_', '_', HeadDirection.Left, 1),

            new Transition(1, '1', '0', HeadDirection.Left, 2),
            new Transition(1, '0', '1', HeadDirection.Left, 1),
            new Transition(1, '+', '_', HeadDirection.Right, 4),


            new Transition(2, '1', '1', HeadDirection.Left, 2),
            new Transition(2, '0', '0', HeadDirection.Left, 2),
            new Transition(2, '+', '+', HeadDirection.Left, 3),
            

            new Transition(3, '1', '0', HeadDirection.Left, 3),
            new Transition(3, '0', '1', HeadDirection.Right, 0),
            new Transition(3, '_', '1', HeadDirection.Right, 0),

            new Transition(4, '1', '_', HeadDirection.Right, 4),
            new Transition(4, '_', '_', HeadDirection.NoMove, -1)
        };

        public static List<Transition> UnarySubstraction() => new()
        {
            new Transition(0, '1', '1', HeadDirection.Right, 0),
            new Transition(0, '-', '-', HeadDirection.Right, 1),

            new Transition(1, 'f', 'f', HeadDirection.Right, 1),
            new Transition(1, '_', '_', HeadDirection.Left, 5),
            new Transition(1, '1', 'f', HeadDirection.Left, 2),


            new Transition(2, 'f', 'f', HeadDirection.Left, 2),
            new Transition(2, '-', '-', HeadDirection.Left, 3),

            new Transition(3, '1', '1', HeadDirection.Left, 3),
            new Transition(3, '_', '_', HeadDirection.Right, 4),

            new Transition(4, '1', '_', HeadDirection.Right, 0),

            new Transition(5, 'f', '_', HeadDirection.Left, 5),
            new Transition(5, '-', '_', HeadDirection.Left, -1)

        };

        public static List<Transition> UnaryMultiplication() => new()
        {
            new Transition(0, '_', '_', HeadDirection.Right, 1),
            new Transition(0, '1', '_', HeadDirection.Right, 2),

            new Transition(1, '_', '_', HeadDirection.Right, 14),
            new Transition(1, '1', '_', HeadDirection.Right, 2),

            new Transition(2, '_', '_', HeadDirection.Right, 3),
            new Transition(2, '1', '1', HeadDirection.Right, 2),

            new Transition(3, '_', '_', HeadDirection.Left, 15),
            new Transition(3, '1', '_', HeadDirection.Right, 4),

            new Transition(4, '_', '_', HeadDirection.Right, 5),
            new Transition(4, '1', '1', HeadDirection.Right, 4),

            new Transition(5, '_', '1', HeadDirection.Left, 6),
            new Transition(5, '1', '1', HeadDirection.Right, 5),

            new Transition(6, '_', '_', HeadDirection.Left, 7),
            new Transition(6, '1', '1', HeadDirection.Left, 6),

            new Transition(7, '_', '1', HeadDirection.Left, 9),
            new Transition(7, '1', '1', HeadDirection.Left, 8),

            new Transition(8, '_', '1', HeadDirection.Right, 3),
            new Transition(8, '1', '1', HeadDirection.Left, 8),

            new Transition(9, '_', '_', HeadDirection.Left, 10),
            new Transition(9, '1', '1', HeadDirection.Left, 9),

            new Transition(10, '_', '_', HeadDirection.Right, 12),
            new Transition(10, '1', '1', HeadDirection.Left, 11),

            new Transition(11, '_', '_', HeadDirection.Right, 0),
            new Transition(11, '1', '1', HeadDirection.Left, 11),

            new Transition(12, '_', '_', HeadDirection.Right, 12),
            new Transition(12, '1', '_', HeadDirection.Right, 13),

            new Transition(13, '_', '_', HeadDirection.NoMove, -1),
            new Transition(13, '1', '_', HeadDirection.Right, 13),

            new Transition(14, '_', '_', HeadDirection.NoMove, -1),
            new Transition(14, '1', '_', HeadDirection.Right, 14),

            new Transition(15, '_', '_', HeadDirection.Left, 16),
            new Transition(15, '1', '_', HeadDirection.Left, 15),

            new Transition(16, '_', '_', HeadDirection.NoMove, -1),
            new Transition(16, '1', '_', HeadDirection.Left, 16)
        };

        public static List<Transition> Translation() => new()
        {
            new Transition(0, '_', '_', HeadDirection.Right, 0),
            new Transition(0, '1', 'f', HeadDirection.Right, 1),

            new Transition(1, '1', '1', HeadDirection.Right, 1),
            new Transition(1, '$', '$', HeadDirection.Right, 7),

            new Transition(7, '_', '1', HeadDirection.Left, 4),
            new Transition(7, '0', '0', HeadDirection.Right, 2),
            new Transition(7, '1', '1', HeadDirection.Right, 2),
            new Transition(7, '2', '2', HeadDirection.Right, 2),
            new Transition(7, '3', '3', HeadDirection.Right, 2),
            new Transition(7, '4', '4', HeadDirection.Right, 2),
            new Transition(7, '5', '5', HeadDirection.Right, 2),
            new Transition(7, '6', '6', HeadDirection.Right, 2),
            new Transition(7, '7', '7', HeadDirection.Right, 2),
            new Transition(7, '8', '8', HeadDirection.Right, 2),
            new Transition(7, '9', '9', HeadDirection.Right, 2),

            new Transition(2, '0', '0', HeadDirection.Right, 2),
            new Transition(2, '1', '1', HeadDirection.Right, 2),
            new Transition(2, '2', '2', HeadDirection.Right, 2),
            new Transition(2, '3', '3', HeadDirection.Right, 2),
            new Transition(2, '4', '4', HeadDirection.Right, 2),
            new Transition(2, '5', '5', HeadDirection.Right, 2),
            new Transition(2, '6', '6', HeadDirection.Right, 2),
            new Transition(2, '7', '7', HeadDirection.Right, 2),
            new Transition(2, '8', '8', HeadDirection.Right, 2),
            new Transition(2, '9', '9', HeadDirection.Right, 2),
            new Transition(2, '_', '_', HeadDirection.Left, 3),

            new Transition(3, '0', '1', HeadDirection.Left, 4),
            new Transition(3, '1', '2', HeadDirection.Left, 4),
            new Transition(3, '2', '3', HeadDirection.Left, 4),
            new Transition(3, '3', '4', HeadDirection.Left, 4),
            new Transition(3, '4', '5', HeadDirection.Left, 4),
            new Transition(3, '5', '6', HeadDirection.Left, 4),
            new Transition(3, '6', '7', HeadDirection.Left, 4),
            new Transition(3, '7', '8', HeadDirection.Left, 4),
            new Transition(3, '8', '9', HeadDirection.Left, 4),
            new Transition(3, '9', '9', HeadDirection.Left, 8),

            new Transition(8, '$', '$', HeadDirection.Right, 9),
            new Transition(8, '0', '1', HeadDirection.Right, 10),
            new Transition(8, '1', '2', HeadDirection.Right, 10),
            new Transition(8, '2', '3', HeadDirection.Right, 10),
            new Transition(8, '3', '4', HeadDirection.Right, 10),
            new Transition(8, '4', '5', HeadDirection.Right, 10),
            new Transition(8, '5', '6', HeadDirection.Right, 10),
            new Transition(8, '6', '7', HeadDirection.Right, 10),
            new Transition(8, '7', '8', HeadDirection.Right, 10),
            new Transition(8, '8', '9', HeadDirection.Right, 10),
            new Transition(8, '9', '9', HeadDirection.Left, 9),

            new Transition(9, '$', '$', HeadDirection.Right, 9),
            new Transition(9, '9', '1', HeadDirection.Right, 11),
            new Transition(9, '_', '0', HeadDirection.Left, 4),
           
            new Transition(11, '9', '0', HeadDirection.Right, 11),
            new Transition(11, '_', '_', HeadDirection.NoMove, 9),

            new Transition(10, '9', '0', HeadDirection.Left, 4),

            new Transition(4, '0', '0', HeadDirection.Left, 4),
            new Transition(4, '1', '1', HeadDirection.Left, 4),
            new Transition(4, '2', '2', HeadDirection.Left, 4),
            new Transition(4, '3', '3', HeadDirection.Left, 4),
            new Transition(4, '4', '4', HeadDirection.Left, 4),
            new Transition(4, '5', '5', HeadDirection.Left, 4),
            new Transition(4, '6', '6', HeadDirection.Left, 4),
            new Transition(4, '7', '7', HeadDirection.Left, 4),
            new Transition(4, '8', '8', HeadDirection.Left, 4),
            new Transition(4, '9', '9', HeadDirection.Left, 4),
            new Transition(4, '$', '$', HeadDirection.Left, 5),

            new Transition(5, 'f', '_', HeadDirection.NoMove, -1),

            new Transition(5, '1', '1', HeadDirection.Left, 6),

            new Transition(6, '1', '1', HeadDirection.Left, 6),
            new Transition(6, 'f', '_', HeadDirection.Right, 0),
        };
    }
}
