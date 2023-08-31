using System.Collections.Generic;
using Brigadier.Unity.Context;

namespace Brigadier.Unity
{
	public delegate IList<TSource> RedirectModifier<TSource>(CommandContext<TSource> context);
}
