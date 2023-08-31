using Brigadier.Unity.Context;

namespace Brigadier.Unity
{
    public delegate int Command<TSource>(CommandContext<TSource> context);
}
