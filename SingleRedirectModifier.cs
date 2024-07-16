using Brigadier.Context;
using Brigadier.Exceptions;

namespace Brigadier
{
    ///<exception cref="CommandSyntaxException" />
    public delegate TSource SingleRedirectModifier<TSource>(CommandContext<TSource> context);
}
