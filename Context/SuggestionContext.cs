using Brigadier.Tree;

namespace Brigadier.Context
{
    public class SuggestionContext<TSource>
    {
        public readonly CommandNode<TSource> Parent;
        public readonly int StartPos;

        public SuggestionContext(CommandNode<TSource> parent, int startPos)
        {
            Parent = parent;
            StartPos = startPos;
        }
    }
}
