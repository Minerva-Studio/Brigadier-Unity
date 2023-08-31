using System.Collections.Generic;
using System.Threading.Tasks;
using Brigadier.Unity.Context;
using Brigadier.Unity.Exceptions;
using Brigadier.Unity.Suggestion;

namespace Brigadier.Unity.ArgumentTypes
{
	public abstract class ArgumentType<T> 
	{
		/// <exception cref="CommandSyntaxException"></exception>
		public abstract T Parse(IStringReader reader);
		
		public virtual Task<Suggestions> ListSuggestions<TSource>(CommandContext<TSource> context, SuggestionsBuilder builder)
		{
			return Suggestions.Empty();
		}

		public virtual IEnumerable<string> Examples => new string[0];
	}
}
