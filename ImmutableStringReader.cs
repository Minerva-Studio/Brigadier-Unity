using System;

namespace Brigadier
{
    public interface IImmutableStringReader
    {
        string String { get; }

        int RemainingLength { get; }

        int TotalLength { get; }

        int Cursor { get; }

        string Read { get; }

        /// <summary>
        /// NOT STANDARD BRIGADIER
        /// </summary>
        ReadOnlySpan<char> ReadSpan { get; }

        string Remaining { get; }

        /// <summary>
        /// NOT STANDARD BRIGADIER
        /// </summary>
        ReadOnlySpan<char> RemainingSpan { get; }

        bool CanRead(int length);

        bool CanRead();

        char Peek();

        char Peek(int offset);
    }
}
