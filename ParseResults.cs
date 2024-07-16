using Brigadier.Context;
using Brigadier.Exceptions;
using Brigadier.Tree;
using System.Collections.Generic;

namespace Brigadier
{
    public class ParseResults<TSource>
    {
        public ParseResults(CommandContextBuilder<TSource> context, IImmutableStringReader reader, IDictionary<CommandNode<TSource>, CommandSyntaxException> exceptions)
        {
            Context = context;
            Reader = reader;
            Exceptions = exceptions;
        }

        public ParseResults(CommandContextBuilder<TSource> context)
            : this(context, new StringReader(""), new Dictionary<CommandNode<TSource>, CommandSyntaxException>())
        {

        }

        public CommandContextBuilder<TSource> Context { get; }

        public IImmutableStringReader Reader { get; }

        public IDictionary<CommandNode<TSource>, CommandSyntaxException> Exceptions { get; }
    }
}
