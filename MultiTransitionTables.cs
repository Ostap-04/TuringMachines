using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public static class MultiTransitionTables
    {
        public static List<UniversalTransition> Polindrom() => new()
        {
            new UniversalTransition(0, new char[] {'1', '_'}, new char[] {'_', '1'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(0, new char[] {'0', '_'}, new char[] {'_', '0'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(0, new char[] {'_', '_'}, new char[] {'_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove}, -1),

            new UniversalTransition(1, new char[] {'1', '1'}, new char[] {'1', '1'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'0', '1'}, new char[] {'0', '1'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'1', '0'}, new char[] {'1', '0'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'0', '0'}, new char[] {'0', '0'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '0'}, new char[] {'_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(1, new char[] {'_', '1'}, new char[] {'_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(1, new char[] {'_', '_'}, new char[] {'_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 2),

            new UniversalTransition(2, new char[] {'1', '1'}, new char[] {'_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Right}, 3),
            new UniversalTransition(2, new char[] {'1', '0'}, new char[] {'_', 'e'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, -1),
            new UniversalTransition(2, new char[] {'0', '0'}, new char[] {'_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Right}, 3),
            new UniversalTransition(2, new char[] {'0', '1'}, new char[] {'_', 'e'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, -1),
            new UniversalTransition(2, new char[] {'_', '0'}, new char[] {'_', '0'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove}, -1),
            new UniversalTransition(2, new char[] {'_', '1'}, new char[] {'_', '1'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove}, -1),
            
            new UniversalTransition(3, new char[] {'1', '_'}, new char[] {'1', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 3),
            new UniversalTransition(3, new char[] {'0', '_'}, new char[] {'0', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 3),
            new UniversalTransition(3, new char[] {'_', '_'}, new char[] {'_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 0),
        };

        public static List<UniversalTransition> ToPower() => new()
        {
            new UniversalTransition(0, new char[] {'1', '_'}, new char[] {'f', '1'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.Right}, 1),
            new UniversalTransition(0, new char[] {'_', '_'}, new char[] {'_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove}, -1),

            new UniversalTransition(1, new char[] {'1', '_'}, new char[] {'1', '1'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.Right}, 1),
            new UniversalTransition(1, new char[] {'_', '_'}, new char[] {'_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove}, 2),

            new UniversalTransition(2, new char[] {'1', '_'}, new char[] {'1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Right}, 2),
            new UniversalTransition(2, new char[] {'f', '_'}, new char[] {'f', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove}, 0),
        };

        public static List<UniversalTransition> BinaryAddition() => new()
        {
            new UniversalTransition(0, new char[] {'1', '_', '_'}, new char[] {'1', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'0', '_', '_'}, new char[] {'0', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),

            new UniversalTransition(1, new char[] {'_', '1', '_'}, new char[] {'_', '1', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '0', '_'}, new char[] {'_', '0', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),

            new UniversalTransition(2, new char[] {'0', '1', '_'}, new char[] {'0', '1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'1', '0', '_'}, new char[] {'1', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'0', '0', '_'}, new char[] {'0', '0', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'1', '1', '_'}, new char[] {'1', '1', '0'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, -1),
            new UniversalTransition(2, new char[] {'0', '1', '1'}, new char[] {'0', '1', '0'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '0', '1'}, new char[] {'1', '0', '0'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '0', '1'}, new char[] {'0', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'1', '1', '1'}, new char[] {'1', '1', '1'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'_', '_', '1'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'1', '_', '1'}, new char[] {'1', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '_', '1'}, new char[] {'0', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'_', '1', '1'}, new char[] {'_', '1', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'_', '0', '1'}, new char[] {'_', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 2),

            new UniversalTransition(3, new char[] {'1', '1', '_'}, new char[] {'1', '1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'0', '1', '_'}, new char[] {'0', '1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'1', '0', '_'}, new char[] {'1', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'_', '_', '1'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 3),
            new UniversalTransition(3, new char[] {'_', '_', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(3, new char[] {'1', '_', '_'}, new char[] {'1', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 2),
            new UniversalTransition(3, new char[] {'_', '1', '_'}, new char[] {'_', '1', '1'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.Left}, 2),
        };

        public static List<UniversalTransition> DecimalSubstraction() => new()
        {
            new UniversalTransition(0, new char[] {'0', '_', '_'}, new char[] {'0', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'1', '_', '_'}, new char[] {'1', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'2', '_', '_'}, new char[] {'2', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'3', '_', '_'}, new char[] {'3', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'4', '_', '_'}, new char[] {'4', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'5', '_', '_'}, new char[] {'5', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'6', '_', '_'}, new char[] {'6', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'7', '_', '_'}, new char[] {'7', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'8', '_', '_'}, new char[] {'8', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'9', '_', '_'}, new char[] {'9', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 0),
            new UniversalTransition(0, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),

            new UniversalTransition(1, new char[] {'_', '0', '_'}, new char[] {'_', '0', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '1', '_'}, new char[] {'_', '1', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '2', '_'}, new char[] {'_', '2', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '3', '_'}, new char[] {'_', '3', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '4', '_'}, new char[] {'_', '4', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '5', '_'}, new char[] {'_', '5', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '6', '_'}, new char[] {'_', '6', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '7', '_'}, new char[] {'_', '7', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '8', '_'}, new char[] {'_', '8', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '9', '_'}, new char[] {'_', '9', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Right, HeadDirection.NoMove}, 1),
            new UniversalTransition(1, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),

            new UniversalTransition(2, new char[] {'0', '0', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'0', '1', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '2', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '3', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '4', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '5', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '6', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '7', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '8', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'0', '9', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),

            new UniversalTransition(2, new char[] {'1', '0', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'1', '1', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'1', '2', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '3', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '4', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '5', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '6', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '7', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '8', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'1', '9', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),

            new UniversalTransition(2, new char[] {'2', '0', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'2', '1', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'2', '2', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'2', '3', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '4', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '5', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '6', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '7', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '8', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'2', '9', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'3', '0', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'3', '1', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'3', '2', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'3', '3', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'3', '4', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'3', '5', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'3', '6', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'3', '7', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'3', '8', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'3', '9', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'4', '0', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'4', '1', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'4', '2', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'4', '3', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'4', '4', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'4', '5', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'4', '6', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'4', '7', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'4', '8', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'4', '9', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'5', '0', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '1', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '2', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '3', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '4', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '5', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'5', '6', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'5', '7', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'5', '8', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'5', '9', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'6', '0', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '1', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '2', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '3', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '4', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '5', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '6', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'6', '7', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'6', '8', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'6', '9', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'7', '0', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '1', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '2', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '3', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '4', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '5', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '6', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '7', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'7', '8', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
            new UniversalTransition(2, new char[] {'7', '9', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'8', '0', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '1', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '2', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '3', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '4', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '5', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '6', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '7', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '8', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'8', '9', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.Left}, 3),
                                                                                
            new UniversalTransition(2, new char[] {'9', '0', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '1', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '2', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '3', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '4', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '5', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '6', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '7', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '8', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'9', '9', '_'}, new char[] {'_', '_', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 2),
            new UniversalTransition(2, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, -1),

            new UniversalTransition(2, new char[] {'0', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'1', '_', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'2', '_', '_'}, new char[] {'_', '_', '2'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'3', '_', '_'}, new char[] {'_', '_', '3'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'4', '_', '_'}, new char[] {'_', '_', '4'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'5', '_', '_'}, new char[] {'_', '_', '5'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'6', '_', '_'}, new char[] {'_', '_', '6'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'7', '_', '_'}, new char[] {'_', '_', '7'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'8', '_', '_'}, new char[] {'_', '_', '8'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),
            new UniversalTransition(2, new char[] {'9', '_', '_'}, new char[] {'_', '_', '9'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.Left}, -1),

            new UniversalTransition(3, new char[] {'0', '_', '_'}, new char[] {'9', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.NoMove}, 4),
            new UniversalTransition(3, new char[] {'1', '_', '_'}, new char[] {'0', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'2', '_', '_'}, new char[] {'1', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'3', '_', '_'}, new char[] {'2', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'4', '_', '_'}, new char[] {'3', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'5', '_', '_'}, new char[] {'4', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'6', '_', '_'}, new char[] {'5', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'7', '_', '_'}, new char[] {'6', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'8', '_', '_'}, new char[] {'7', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),
            new UniversalTransition(3, new char[] {'9', '_', '_'}, new char[] {'8', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.Left, HeadDirection.NoMove}, 2),

            new UniversalTransition(4, new char[] {'0', '_', '_'}, new char[] {'9', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.NoMove, HeadDirection.NoMove}, 4),
            new UniversalTransition(4, new char[] {'1', '_', '_'}, new char[] {'0', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'2', '_', '_'}, new char[] {'1', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'3', '_', '_'}, new char[] {'2', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'4', '_', '_'}, new char[] {'3', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'5', '_', '_'}, new char[] {'4', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'6', '_', '_'}, new char[] {'5', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'7', '_', '_'}, new char[] {'6', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'8', '_', '_'}, new char[] {'7', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(4, new char[] {'9', '_', '_'}, new char[] {'8', '_', '_'}, new HeadDirection[] {HeadDirection.NoMove, HeadDirection.NoMove, HeadDirection.NoMove}, 5),

            new UniversalTransition(5, new char[] {'0', '_', '_'}, new char[] {'0', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'1', '_', '_'}, new char[] {'1', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'2', '_', '_'}, new char[] {'2', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'3', '_', '_'}, new char[] {'3', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'4', '_', '_'}, new char[] {'4', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'5', '_', '_'}, new char[] {'5', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'6', '_', '_'}, new char[] {'6', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'7', '_', '_'}, new char[] {'7', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'8', '_', '_'}, new char[] {'8', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'9', '_', '_'}, new char[] {'9', '_', '_'}, new HeadDirection[] {HeadDirection.Right, HeadDirection.NoMove, HeadDirection.NoMove}, 5),
            new UniversalTransition(5, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.NoMove}, 2),
        };

        public static List<UniversalTransition> BinaryDivision() => new()
        {
            new UniversalTransition(0, new char[] {'0', '0', '_'}, new char[] {'0', '0', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 0),
            new UniversalTransition(0, new char[] {'0', '1', '_'}, new char[] {'0', '1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 0),
            new UniversalTransition(0, new char[] {'1', '0', '_'}, new char[] {'1', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 0),
            new UniversalTransition(0, new char[] {'1', '1', '_'}, new char[] {'1', '1', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 1),
            new UniversalTransition(0, new char[] {'_', '_', '_'}, new char[] {'_', '_', '_'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, -1),

            new UniversalTransition(1, new char[] {'0', '0', '_'}, new char[] {'0', '0', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 0),
            new UniversalTransition(1, new char[] {'0', '1', '_'}, new char[] {'0', '1', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 1),
            new UniversalTransition(1, new char[] {'1', '0', '_'}, new char[] {'1', '0', '0'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 1),
            new UniversalTransition(1, new char[] {'1', '1', '_'}, new char[] {'1', '1', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, 1),
            new UniversalTransition(1, new char[] {'_', '_', '_'}, new char[] {'_', '_', '1'}, new HeadDirection[] {HeadDirection.Left, HeadDirection.Left, HeadDirection.Left}, -1),

        };
    }
}

// 1 Tape: 10001000100
// 2 Tape: n of 0
// 3 Tape: copy of Tape 2


// 4 Tape: for 1 sum
// 5 Tape: for 2 sum
// 4 and 5 Tape works with 3 Tape

// ______2_3_34
//  123(3)
// 1 23     2 13       3 12

// 1234(7)
// 1 234    2 134   3 124   4 123
// 12 34    13 24   14 23

// 12345(15)
// 1 2345   2 1345  3 1245  4 1235  5 1234
// 12 345   13 245  14 235  15 234  23 145  24 135  25 134 34 125   35 124  45 123

// 
