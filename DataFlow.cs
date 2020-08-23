using System.Collections.Generic;

namespace Generics
{
    public class DataFlow : IDataFlow<string>
    {
        public List<IBlock<string>> Blocks { get; set; }
        public DataFlow()
        {
            Blocks = new List<IBlock<string>>();
        }

        public string RunFlow(string input)
        {
            string output = input;
            foreach (IBlock<string> block in Blocks)
            {
                output = block.Process(output);
            }
            return output;
        }

        public void AddBlock(IBlock<string> block)
        {
            Blocks.Add(block);
        }
    }
}
