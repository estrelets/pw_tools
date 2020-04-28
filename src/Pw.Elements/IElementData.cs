using System.Collections.Generic;

namespace Pw.Elements
{
    public interface IElementData
    {
        List<IElement[]> Lists { get; set; }
        ElementMetadata ElementMetadata { get; set; }
    }
}
