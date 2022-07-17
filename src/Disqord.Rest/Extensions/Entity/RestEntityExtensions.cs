﻿using System.ComponentModel;
using Qommon;

namespace Disqord.Rest;

[EditorBrowsable(EditorBrowsableState.Never)]
public static partial class RestEntityExtensions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IRestClient GetRestClient(this IClientEntity entity)
    {
        Guard.IsNotNull(entity);

        return Guard.IsAssignableToType<IRestClient>(entity.Client);
    }
}
