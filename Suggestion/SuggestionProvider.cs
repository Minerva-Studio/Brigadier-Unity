using Brigadier.Context;
using System.Threading.Tasks;

namespace Brigadier.Suggestion
{
    public delegate Task<Suggestions> SuggestionProvider<TSource>(CommandContext<TSource> context, SuggestionsBuilder builder);
}
