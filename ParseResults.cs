using System.Collections.Generic;
using Brigadier.Unity.Context;
using Brigadier.Unity.Exceptions;
using Brigadier.Unity.Tree;

namespace Brigadier.Unity
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
