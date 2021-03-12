﻿using System.Threading.Tasks;
using Disqord.Gateway.Api;
using Disqord.Gateway.Api.Models;

namespace Disqord.Gateway.Default.Dispatcher
{
    public class MessageDeleteHandler : Handler<MessageDeletedJsonModel, MessageDeletedEventArgs>
    {
        public override ValueTask<MessageDeletedEventArgs> HandleDispatchAsync(IGatewayApiClient shard, MessageDeletedJsonModel model)
        {
            CachedUserMessage message = null;
            if (model.GuildId.HasValue && CacheProvider.TryGetMessages(model.ChannelId, out var cache))
            {
                cache.TryRemove(model.Id, out message);
            }

            var e = new MessageDeletedEventArgs(model.GuildId.GetValueOrNullable(), model.ChannelId, model.Id, message);
            return new(e);
        }
    }
}
