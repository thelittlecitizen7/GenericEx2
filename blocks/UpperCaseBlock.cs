namespace Generics.blocks
{
    public class UpperCaseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
