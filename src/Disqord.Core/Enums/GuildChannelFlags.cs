using System;

namespace Disqord;

/// <summary>
///     Represents the flags of a guild channel.
/// </summary>
[Flags]
public enum GuildChannelFlags
{
    /// <summary>
    ///     The thread channel is pinned to the top of its parent forum channel.
    /// </summary>
    Pinned = 1 << 1
}
