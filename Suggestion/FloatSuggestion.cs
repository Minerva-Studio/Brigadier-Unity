using Brigadier.Context;
using System;
using HashCode = Brigadier.Util.HashCode;

namespace Brigadier.Suggestion
{
    public class FloatSuggestion : Suggestion, IEquatable<FloatSuggestion>
    {
        public FloatSuggestion(StringRange range, float value, IMessage tooltip = null)
            : base(range, value.ToString(), tooltip)
        {
            Value = value;
        }

        public float Value { get; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is FloatSuggestion other
                   && Equals(other);
        }

        public bool Equals(FloatSuggestion other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value
                   && base.Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Start
                .Hash(Value);
        }

        public override string ToString()
        {
            return $"FloatSuggestion{{value={Value}, range={Range}, text='{Text}', tooltip='{Tooltip}'}}";
        }

        public override int CompareTo(Suggestion o)
        {
            if (o is FloatSuggestion floatSuggestion)
            {
                return floatSuggestion.Value.CompareTo(Value);
            }
            return base.CompareTo(o);
        }

        public override int CompareToIgnoreCase(Suggestion b)
        {
            return CompareTo(b);
        }
    }
}
