namespace Generics.blocks
{
    public class ReplaceAWithSixBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.Replace("A", "6");
        }
    }
}
