using Brigadier.Unity.Context;
using Brigadier.Unity.Exceptions;

namespace Brigadier.Unity
{
	///<exception cref="CommandSyntaxException" />
	public delegate TSource SingleRedirectModifier<TSource>(CommandContext<TSource> context);
}
