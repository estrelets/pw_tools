using System;
using System.Collections.Generic;
using Pw.Serializer.Plans;

namespace Pw.Serializer
{
    internal class PlansCache
    {
        private static readonly Lazy<PlansCache> InstanceFabric = new Lazy<PlansCache>(() => new PlansCache());

        private readonly Dictionary<Type, IPlanItem> _plans = new Dictionary<Type, IPlanItem>();

        private PlansCache()
        {
        }

        internal static PlansCache Instance => InstanceFabric.Value;

        internal IPlanItem GetPlan<T>()
        {
            var type = typeof(T);
            if (!_plans.ContainsKey(type)) _plans[type] = new PlanBuilder().Build(type);

            return _plans[type];
        }
    }
}
