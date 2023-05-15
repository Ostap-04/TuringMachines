using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachines
{
    public class Head
    {
        public const char Blank = 'b';
        public List<char> Tape { get; set; }
        public int HeadPosition { get; set; }

        public Head(List<char> tape, int headPosition)
        {
            Tape = tape;
            HeadPosition = headPosition;
        }

        public Head(Head other) {
            Tape = new List<char>(other.Tape);
            HeadPosition = other.HeadPosition;
        }

        public void Write(char toWrite)
        {
            Tape[HeadPosition] = toWrite;
        }

        public void MoveLeft()
        {
            if (HeadPosition == 0)
                Tape.Insert(0, Blank);
            else
                HeadPosition -= 1;
        }

        public void MoveRight()
        {
            if (HeadPosition == Tape.Count() - 1)
            {
                Tape = new List<char>(Tape.Append(Blank));
                HeadPosition += 1;
            }
            else
                HeadPosition += 1;
        }

        public void Move(HeadDirection direction)
        {
            switch (direction)
            {
                case HeadDirection.Left:
                    MoveLeft();
                    return;
                case HeadDirection.NoMove:
                    return;
                case HeadDirection.Right:
                    MoveRight();
                    return;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public char Read() => Tape.ElementAt(HeadPosition);

        public override string ToString() => $@"{Tape.Select(GetChar).Aggregate((agg, next) => agg + next)}";
        private string GetChar(char c, int index) => index == HeadPosition ? $"({c})" : c.ToString();
    }

    public enum HeadDirection
    {
        Left = -1,
        NoMove = 0,
        Right = 1
    }
}
