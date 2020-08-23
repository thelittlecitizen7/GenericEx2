using Generics.blocks;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            IBlock<string> block1 = new UpperCaseBlock();
            IBlock<string> block2 = new ReverseBlock();
            IBlock<string> block3= new ReplaceAWithSixBlock();
            
            DataFlow flow = new DataFlow();
            flow.AddBlock(block1);
            flow.AddBlock(block2);
            flow.AddBlock(block3);
            string result = flow.RunFlow("liorA");
            Console.WriteLine(result);
        }
    }
}
