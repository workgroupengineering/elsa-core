﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Services;

namespace Elsa.Triggers
{
    public abstract class TriggerProvider<T, TActivity> : ITriggerProvider where T : ITrigger where TActivity : IActivity
    {
        public Type ForType() => typeof(T);
        public Type ForActivityType() => typeof(TActivity);
        public abstract ValueTask<ITrigger> GetTriggerAsync(TriggerProviderContext<TActivity> context, CancellationToken cancellationToken);

        ValueTask<ITrigger> ITriggerProvider.GetTriggerAsync(TriggerProviderContext context, CancellationToken cancellationToken) =>
            GetTriggerAsync(new TriggerProviderContext<TActivity>(context.ActivityExecutionContext), cancellationToken);
    }
}