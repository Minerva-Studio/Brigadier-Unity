using Brigadier.Unity.Context;

namespace Brigadier.Unity
{
    public delegate void ResultConsumer<TSource>(CommandContext<TSource> context, bool success, int result);
}
