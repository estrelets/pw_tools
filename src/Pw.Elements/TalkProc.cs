using Pw.Serializer;

namespace Pw.Elements
{
    public class TalkProc : IElementsType
    {
        [Order(0)]
        public uint IdTalk { get; set; }

        [Order(1)]
        [Size(64)]
        [NameString]
        public string Text { get; set; }

        [Order(2)]
        [DynamicSize]
        public Window[] Windows { get; set; }


        public class Window
        {
            [Order(0)]
            public uint Id { get; set; }
            [Order(1)]
            public uint IdParent { get; set; }

            [Order(2)]
            [NameString]
            [DynamicSize]
            public string TalkText { get; set; }

            [Order(3)]
            [DynamicSize]
            public Option[] Options { get; set; }

            public class Option
            {
                [Order(0)]
                public uint Id { get; set; }

                [Order(1)]
                [Size(64)]
                [NameString]
                public string Text { get; set; }

                [Order(2)]
                public uint Param { get; set; }
            }
        }
    }
}
