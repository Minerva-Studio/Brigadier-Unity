using Brigadier.Tree;
using System.Collections.Generic;

namespace Brigadier
{
    public delegate void AmbiguityConsumer<TSource>(CommandNode<TSource> parent, CommandNode<TSource> child, CommandNode<TSource> sibling,
        IEnumerable<string> inputs);

}
