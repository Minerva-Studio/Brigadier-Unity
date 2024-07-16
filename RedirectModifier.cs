using Brigadier.Context;
using System.Collections.Generic;

namespace Brigadier
{
    public delegate IList<TSource> RedirectModifier<TSource>(CommandContext<TSource> context);
}
