using Brigadier.Context;

namespace Brigadier
{
    public delegate int Command<TSource>(CommandContext<TSource> context);
}
