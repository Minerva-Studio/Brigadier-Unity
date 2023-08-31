using System.Threading.Tasks;
using Brigadier.Unity.Context;

namespace Brigadier.Unity.Suggestion
{
	public delegate Task<Suggestions> SuggestionProvider<TSource>(CommandContext<TSource> context, SuggestionsBuilder builder);
}
