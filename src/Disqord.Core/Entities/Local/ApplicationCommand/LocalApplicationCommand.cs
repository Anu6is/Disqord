﻿using System.Collections.Generic;
using System.Globalization;
using Qommon;
using Qommon.Collections;

namespace Disqord;

public abstract class LocalApplicationCommand : ILocalConstruct<LocalApplicationCommand>
{
    /// <summary>
    ///     Gets or sets the name of this command.
    /// </summary>
    /// <remarks>
    ///     This property is required.
    /// </remarks>
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     Gets or sets the localizations of the name of this command.
    /// </summary>
    public Optional<IDictionary<CultureInfo, string>> NameLocalizations { get; set; }

    /// <summary>
    ///     Gets or sets whether this command is enabled by default.
    /// </summary>
    /// <remarks>
    ///     If not set, defaults to <see langword="true"/>.
    /// </remarks>
    public Optional<bool> IsEnabledByDefault { get; set; }

    /// <summary>
    ///     Gets or sets the default required permissions of members of this command.
    /// </summary>
    public Optional<Permission> DefaultRequiredMemberPermissions { get; set; }

    /// <summary>
    ///     Gets or sets whether this command is enabled in private channels.
    /// </summary>
    public Optional<bool> IsEnabledInPrivateChannels { get; set; }

    protected LocalApplicationCommand()
    { }

    protected LocalApplicationCommand(LocalApplicationCommand other)
    {
        Guard.IsNotNull(other);

        Name = other.Name;
        NameLocalizations = Optional.Convert(other.NameLocalizations, localizations => localizations.ToDictionary() as IDictionary<CultureInfo, string>);
        IsEnabledByDefault = other.IsEnabledByDefault;
        DefaultRequiredMemberPermissions = other.DefaultRequiredMemberPermissions;
        IsEnabledInPrivateChannels = other.IsEnabledInPrivateChannels;
    }

    public abstract LocalApplicationCommand Clone();
}
