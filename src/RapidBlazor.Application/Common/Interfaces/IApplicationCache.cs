﻿using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBlazor.Application.Common.Interfaces
{
    public interface IApplicationCache
    {
        object Get(object key);
        TItem Get<TItem>(object key);
        TItem Set<TItem>(object key, TItem value);
        TItem Set<TItem>(object key, TItem value, IChangeToken expirationToken);
        TItem Set<TItem>(object key, TItem value, DateTimeOffset absoluteExpiration);
        TItem Set<TItem>(object key, TItem value, TimeSpan absoluteExpirationRelativeToNow);
        bool TryGetValue<TItem>(object key, out TItem value);
    }
}
