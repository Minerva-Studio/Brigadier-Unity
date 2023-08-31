using System.Collections.Generic;
using Brigadier.Unity.Tree;

namespace Brigadier.Unity
{
	public delegate void AmbiguityConsumer<TSource>(CommandNode<TSource> parent, CommandNode<TSource> child, CommandNode<TSource> sibling,
		IEnumerable<string> inputs);

}
