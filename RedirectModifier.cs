using Brigadier.Unity.Context;
using System.Collections.Generic;

namespace Brigadier.Unity
{
    public delegate IList<TSource> RedirectModifier<TSource>(CommandContext<TSource> context);
}
