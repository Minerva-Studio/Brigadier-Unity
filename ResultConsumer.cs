using Brigadier.Context;

namespace Brigadier
{
    public delegate void ResultConsumer<TSource>(CommandContext<TSource> context, bool success, int result);
}
