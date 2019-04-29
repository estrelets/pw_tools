using System.Collections.Generic;

namespace Pw.ElementsSerializer.Plans
{
    public interface ICompositePlanItem : IPlanItem
    {
        IReadOnlyList<IPlanItem> Childs { get; }
    }
}