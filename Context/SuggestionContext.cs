using Brigadier.Unity.Tree;

namespace Brigadier.Unity.Context
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
