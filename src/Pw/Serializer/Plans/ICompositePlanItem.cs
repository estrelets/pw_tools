using System.Collections.Generic;

namespace Pw.Serializer.Plans
{
    public interface ICompositePlanItem : IPlanItem
    {
        IReadOnlyList<IPlanItem> Childs { get; }
    }
}
