using System;
using System.Linq;

namespace Generics.blocks
{
    public class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
