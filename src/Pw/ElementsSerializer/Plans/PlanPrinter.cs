using System;
using System.Linq;

namespace Pw.ElementsSerializer.Plans
{
    internal static class ComplexPlanPrinter
    {
        private static readonly int TabLength = 4;

        internal static string Print(IPlanItem planItem, int nesting)
        {
            if (planItem is ICompositePlanItem compositePlan)
            {
                var childs = compositePlan.Childs
                    .Select(item => Print(item, nesting + 1));

                return $"{CreateTab()}{compositePlan.Accessor} : {Environment.NewLine}" +
                       $"{String.Join(Environment.NewLine, childs)}";
            }
            else if (planItem is StringPlanItem stringPlanItem && stringPlanItem.LengthPlan != null)
            {
                return $"{CreateTab()}{stringPlanItem.LengthPlan}{Environment.NewLine}" +
                       $"{CreateTab()}{stringPlanItem}";
            }
            else
            {
                return $"{CreateTab()}{planItem}";
            }

            string CreateTab() => new string(' ', nesting * TabLength);
        }
    }
}
