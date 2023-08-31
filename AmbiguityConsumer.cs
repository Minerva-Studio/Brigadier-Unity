using Brigadier.Unity.Tree;
using System.Collections.Generic;

namespace Brigadier.Unity
{
    public delegate void AmbiguityConsumer<TSource>(CommandNode<TSource> parent, CommandNode<TSource> child, CommandNode<TSource> sibling,
        IEnumerable<string> inputs);

}
