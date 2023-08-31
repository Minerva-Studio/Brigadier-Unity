using Brigadier.Unity.Context;
using System.Threading.Tasks;

namespace Brigadier.Unity.Suggestion
{
    public delegate Task<Suggestions> SuggestionProvider<TSource>(CommandContext<TSource> context, SuggestionsBuilder builder);
}
