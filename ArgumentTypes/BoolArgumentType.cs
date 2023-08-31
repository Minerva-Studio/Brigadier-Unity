﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Brigadier.Unity.Context;
using Brigadier.Unity.Suggestion;

namespace Brigadier.Unity.ArgumentTypes
{
	public class BoolArgumentType : ArgumentType<bool>
	{
		private static readonly IEnumerable<string> BoolExamples = new[] {"true", "false"};

		internal BoolArgumentType()
		{
		}

		public override bool Parse(IStringReader reader)
		{
			return reader.ReadBoolean();
		}

		public override Task<Suggestions> ListSuggestions<TSource>(CommandContext<TSource> context, SuggestionsBuilder builder)
		{
			if ("true".StartsWith(builder.RemainingLowerCase))
			{
				builder.Suggest("true");
			}
			if ("false".StartsWith(builder.RemainingLowerCase))
			{
				builder.Suggest("false");
			}
			return builder.BuildFuture();
		}

		public override IEnumerable<string> Examples => BoolExamples;
	}
}
